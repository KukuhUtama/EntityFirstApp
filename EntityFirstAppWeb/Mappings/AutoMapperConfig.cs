using EntityFirstApp;
using EntityFirstAppWeb.Areas.User.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFirstAppWeb.Mappings
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {   
             /*AutoMapper Back To Front */
            AutoMapper.Mapper.CreateMap<User, UserView>()
                              .ForMember(dest => dest.UserName,opt => opt.MapFrom(src => src.UserName))
                              .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email));

            /*AutoMapper Front To Back */
        }
    }
}