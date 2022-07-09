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
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDto>()
                .ForMember(dto => dto.Images, i =>
                {
                    i.MapFrom(p => p.Images.Select(x => x));
                })
                .ForMember(dto => dto.Specifications, i =>
                {
                    i.MapFrom(p => p.Specifications.Select(x => x));
                })
                .ForMember(dto => dto.Category, i =>
                {
                    i.MapFrom(p => p.Category.CategoryName);
                })
                .ForMember(dto => dto.CategoryId, i =>
                {
                  i.MapFrom(p => p.CategoryId);
                })
                .ForMember(dto => dto.Price, i =>
                {
                    i.MapFrom(x => x.Prices.OrderByDescending(x => x.CreatedAt).FirstOrDefault());
                });

            CreateMap<Image, ImageDto>();

            CreateMap<ProductSpecification, ProductSpecificationDto>()
                .ForMember(dto => dto.SpecificationValue, s =>
                {
                    s.MapFrom(i => i.SpecificationValue);
                })
                .ForMember(dto => dto.SpecificationName, i =>
                {
                    i.MapFrom(x => x.Specification.SpecificationName);
                });

            CreateMap<Specification, SpecificationDto>()
                .ForMember(dto => dto.SpecificationId, i =>
                {
                    i.MapFrom(x => x.Id);
                }).ReverseMap();

            CreateMap<Category, CategoryDto>()
                .ForMember(dto => dto.CategoryId, i =>
                {
                    i.MapFrom(x => x.Id);
                })
                .ForMember(dto => dto.ChildCategories, i =>
                {
                    i.MapFrom(x => x.ChildCategories.Select(y => y.CategoryName));
                })
                .ForMember(dto => dto.ParentCategoryId, i =>
                {
                    i.MapFrom(x => x.ParentCategory.Id);
                })
                .ReverseMap()
                .ForMember(d => d.ChildCategories, i =>
                {
                    i.Ignore();
                });
           CreateMap<Price, PriceDto>();


            CreateMap<NewProductsDto, Product>()
                .ForMember(s => s.Images, dto => { dto.Ignore(); })
                .ForMember(s => s.Prices, dto => { dto.Ignore(); })
                .ForMember(s => s.Specifications, dto => { dto.Ignore(); });

            CreateMap<NewProductSpecificationDto, ProductSpecification>();
        }
    }
}
