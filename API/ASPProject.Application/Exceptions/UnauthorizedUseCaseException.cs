using ASPProject.Application.UseCases;
using ASPProject.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Application.Exceptions
{
    public class UnauthorizedUseCaseException : Exception
    {
        public UnauthorizedUseCaseException(IUseCase useCase, IApplicationUser user)
            :base($"User with ID {user.Id} tried to execute {useCase.Name} without being authorized.")
        {

        }
    }
}
