using ASPProject.Application.DTOs;
using ASPProject.Domain;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPProject.Implementation.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<RegisterDto, User>()
                .ForMember(u => u.Password, o =>
                {
                    o.PreCondition(dto => !string.IsNullOrWhiteSpace(dto.Password));
                    o.MapFrom(dto => BCrypt.Net.BCrypt.HashPassword(dto.Password));
                });

            CreateMap<User , UserDto > ()
                .ForMember( dto => dto.UseCases, u =>
                {
                    u.MapFrom(x => x.Role.RoleUseCases.Select(y => y.UseCaseId));
                })
                .ForMember(dto => dto.Role, u =>
                {
                    u.MapFrom(x => x.Role.Name);
                })
                .ForMember(dto => dto.CartItems, i =>
                {
                    i.MapFrom(x => x.CartItems.Where(x => x.IsActive).Select(x => x));
                });

      CreateMap<UpdateUserDto, User>();
              //.ForMember(u => u.RoleId, dto =>
              //{
              //  dto.MapFrom(x => x.RoleId);
              //});
      //.ForMember(u => u.Password, dto =>
      //{
      //    dto.MapFrom(x => BCrypt.Net.BCrypt.HashPassword(x.Password));
      //});

      CreateMap<Order, OrderDto>().ReverseMap().ForMember
                (
                    source => source.OrderNumber, opt => opt.Ignore()
                );
      CreateMap<OrderItem, OrderItemDto>()
        .ForMember(dto => dto.ProductName, d =>
        {
          d.MapFrom(x => x.Product.ProductName);
        })
        .ReverseMap().ForMember
          (
              source => source.OrderId, opt => opt.Ignore()
          )
          .ForPath
          (
             source => source.Product.ProductName, opt => opt.Ignore()
          );
    }
    }
}
