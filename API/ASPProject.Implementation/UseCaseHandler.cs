using ASPProject.Application.Exceptions;
using ASPProject.Application.UseCases;
using ASPProject.Domain;
using ASPProjekat.DataAccess;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Implementation
{
    public class UseCaseHandler
    {
        private readonly IUseCaseLogger _useCaseLogger;
        private readonly IApplicationUser _user;

        public UseCaseHandler(IUseCaseLogger useCaseLogger, IApplicationUser user)
        {
            _useCaseLogger = useCaseLogger;
            _user = user;
        }

        public void HandleCommand<TRequest>(ICommand<TRequest> command, TRequest request)
        {
            LogUseCase(command, request);
            isAuthorizedUser(command);
            command.Execute(request);
        }
        public TResponse HandleQuery<TRequest, TResponse>(IQuery<TRequest, TResponse> query, TRequest data)
        {
            LogUseCase(query, data);
            isAuthorizedUser(query);
            return query.Execute(data);
        }

        public void LogUseCase<TRequest>(IUseCase useCase, TRequest data)
        {
            _useCaseLogger.Log(new UseCaseLog
            {
                UseCaseName = useCase.Name,
                Date = DateTime.UtcNow,
                UserId = _user.Id,
                IsAuthorized = _user.AllowedUseCaseIds.Contains(useCase.Id),
                Data = JsonConvert.SerializeObject(data)
            }) ;
        }

        public void isAuthorizedUser(IUseCase useCase)
        {
            var isAuthorized = _user.AllowedUseCaseIds.Contains(useCase.Id);
            if (!isAuthorized)
            {
                throw new UnauthorizedUseCaseException(useCase, _user);
            }
        }
    }
}
