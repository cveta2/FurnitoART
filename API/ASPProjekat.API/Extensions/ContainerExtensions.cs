using ASPProject.Application.UseCases.Commands;
using ASPProject.Application.UseCases.Queries;
using ASPProject.Domain;
using ASPProject.Implementation.UseCases.Commands;
using ASPProject.Implementation.UseCases.Queries;
using ASPProject.Implementation.Validators;
using ASPProjekat.API.Core;
using ASPProjekat.DataAccess;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProjekat.API.Extensions
{
    public static class ContainerExtensions
    { 
        public static void AddValidators(this IServiceCollection services)
        {
            services.AddTransient<RegisterUserValidator>();
            services.AddTransient<UpdateUserValidator>();
            services.AddTransient<AddProductToCartValidator>();
            services.AddTransient<PlaceOrderValidator>();
            services.AddTransient<OrderNumberValidator>();
            services.AddTransient<CategoryValidator>();
            services.AddTransient<SpecificationValidator>();
            services.AddTransient<ProductValidator>();
        }
        public static void AddUseCases(this IServiceCollection services)
        {
            services.AddTransient<IRegisterUserCommand, EfRegisterUserCommand>();
            services.AddTransient<IUpdateUserCommand, EfUpdateUserCommand>();
            services.AddTransient<IGetUsersQuery, EfGetUsersQuery>();
            services.AddTransient<IFindUserQuery, EfFindUserQuery>();
            services.AddTransient<ISearhProductsQuery, EfSearchProductsQuery>();
            services.AddTransient<IFindProductQuery, EfFindProductQuery>();
            services.AddTransient<IDeleteUserCommand, EfDeleteUserCommand>();
            services.AddTransient<IAddProductToCartCommand, EfAddProductToCartCommand>();
            services.AddTransient<IGetCartItems, EfGetCartItems>();
            services.AddTransient<IDeleteItemFromCartCommand, EfDeleteItemFromCartCommand>();
            services.AddTransient<IUpdateCartItemCommand, EfUpdateCartItemCommand>();
            services.AddTransient<IDeleteProductCommand, EfDeleteProductCommand>();
            services.AddTransient<IPlaceOrderCommand, EfPlaceOrderCommand>();
            services.AddTransient<IFindOrderQuery, EfFindOrderQuery>();
            services.AddTransient<ISearchOrdersByDateQuery, EfSearchOrdersByDateQuery>();
            services.AddTransient<IGetCategoriesQuery, EfGetCategoriesQuery>();
            services.AddTransient<IDeleteCategoryCommand, EfDeleteCategoryCommand>();
            services.AddTransient<IAddCategoryCommand, EfAddCategoryCommand>();
            services.AddTransient<IGetSpecificationsQuery, EfGetSpecificationsQuery>();
            services.AddTransient<IDeleteSpecificationCommand, EfDeleteSpecificationCommand>();
            services.AddTransient<IAddSpecificationCommand, EfAddSpecificationCommand>();
            services.AddTransient<IAddProductCommand, EfAddProductCommand>();
            services.AddTransient<IUpdateSpecificationCommand, EfUpdateSpecificationCommand>();
            services.AddTransient<IUpdateCategoryCommand, EfUpdateCategoryCommand>();
            services.AddTransient<IAddSpecificationsForProductCommand, EfAddSpecificationsForProductCommand>();
            services.AddTransient<IUpdateProductCommand, EfUpdateProductCommand>();
            services.AddTransient<ISearchAuditLogsQuery, EfSearchAuditLogsQuery>();
            services.AddTransient<IRemoveItemsFromUsersCart, EfRemoveItemsFromUsersCart>();
        }

        public static void AddJwt(this IServiceCollection services, AppSettings settings)
        {
            services.AddTransient(x =>
            {
                var context = x.GetService<ProjekatContext>();
                var settings = x.GetService<AppSettings>();

                return new JwtManager(context, settings.JwtSettings);
            });


            services.AddAuthentication(options =>
            {
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(cfg =>
            {
                cfg.RequireHttpsMetadata = false;
                cfg.SaveToken = true;
                cfg.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = settings.JwtSettings.Issuer,
                    ValidateIssuer = true,
                    ValidAudience = "Any",
                    ValidateAudience = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(settings.JwtSettings.SecretKey)),
                    ValidateIssuerSigningKey = true,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero
                };
            });
        }

        public static void AddApplicationUser(this IServiceCollection services)
        {
            services.AddTransient<IApplicationUser>(x =>
            {
                var accessor = x.GetService<IHttpContextAccessor>();
                var header = accessor.HttpContext.Request.Headers["Authorization"];

                var claims = accessor.HttpContext.User;

                if (claims == null || claims.FindFirst("UserId") == null)
                {
                    return new AnonymousUser();
                }

                var actor = new LoggedInUser
                {
                    Email = claims.FindFirst("Email").Value,
                    Id = Int32.Parse(claims.FindFirst("UserId").Value),
                    AllowedUseCaseIds = JsonConvert.DeserializeObject<List<int>>(claims.FindFirst("AllowedUseCaseIds").Value)
                };

                return actor;
            });
        }
    }
}
