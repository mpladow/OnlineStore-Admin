using AutoMapper;
using OnlineStore_Admin.Entities;
using OnlineStore_Admin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore_Admin.App_Start
{
    public class MappingConfig: Profile
    {
        public static void RegisterMaps()
        {
            AutoMapper.Mapper.Initialize(config =>
            {
                //config.CreateMap<Product, ProductVM>()
                //    .ForMember(dest => dest.CategoryId, x => x.MapFrom(src => src.RefCategory.CategoryId));
                //config.CreateMap<ProductVM, Product >();
            });
            
        }
    }
}