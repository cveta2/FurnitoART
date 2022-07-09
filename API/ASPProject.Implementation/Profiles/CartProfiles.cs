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
    public class CartProfiles : Profile
    {
        public CartProfiles()
        {
            CreateMap<AddToCartDto, Cart>();
            CreateMap<Cart, CartDto>()
                .ForMember(dto => dto.Product, i =>
                {
                    i.MapFrom(c => c.Product.ProductName);
                })
                .ForMember(dto => dto.ProductPrice, i =>
                {
                    i.MapFrom(c => c.Product.Prices.OrderByDescending(x => x.CreatedAt).FirstOrDefault().PriceValue);
                });

        }
    }
}
