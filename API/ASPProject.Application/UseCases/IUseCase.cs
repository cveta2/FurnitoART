using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Application.UseCases
{
    public interface IUseCase
    {
        int Id { get; }
        string Name { get; }
    }
}
