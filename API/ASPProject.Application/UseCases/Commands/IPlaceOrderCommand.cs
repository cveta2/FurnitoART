﻿using ASPProject.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Application.UseCases.Commands
{
    public interface IPlaceOrderCommand : ICommand<OrderDto>
    {
    }
}