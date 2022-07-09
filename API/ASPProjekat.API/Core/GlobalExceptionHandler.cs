using ASPProject.Application.Exceptions;
using ASPProject.Application.Logging;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPProjekat.API.Core
{
    public class GlobalExceptionHandler
    {
        private readonly IExceptionLogger _logger;
        private readonly RequestDelegate _next;
        public GlobalExceptionHandler(IExceptionLogger logger, RequestDelegate next)
        {
            _logger = logger;
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch(System.Exception ex)
            {
                _logger.Log(ex);

                context.Response.ContentType = "application/json";
                object response = null;
                var statusCode = StatusCodes.Status500InternalServerError;

                if (ex is UnauthorizedUseCaseException)
                {
                    statusCode = StatusCodes.Status403Forbidden;
                }

                if(ex is ValidationException e)
                {
                    statusCode = StatusCodes.Status422UnprocessableEntity;
                    response = new
                    {
                        errors = e.Errors.Select(x => new
                        {
                            message = x.ErrorMessage,
                            property = x.PropertyName
                        })
                    };
                }

                if(ex is UnauthorizedAccessException)
                {
                    statusCode = StatusCodes.Status401Unauthorized;
                }

                if(ex is EntityNotFoundException)
                {
                    statusCode = StatusCodes.Status404NotFound;
                }
                if(ex is ConflictException exep)
                {
                    statusCode = StatusCodes.Status409Conflict;
                    response = new
                    {
                        errors = exep.Message
                    };
                }
                if( ex is UnprocessableEntityException ue)
                {
                    statusCode = StatusCodes.Status422UnprocessableEntity;
                    response = new
                    {
                        errors = ue.Message
                    };
                }

                context.Response.StatusCode = statusCode;
                if (response != null)
                {
                    await context.Response.WriteAsJsonAsync(response);
                }
            }
         }
    }
}
