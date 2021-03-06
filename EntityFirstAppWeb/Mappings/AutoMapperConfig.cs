﻿using EntityFirstApp;
using EntityFirstApp.Model;
using EntityFirstAppWeb.Areas.Rent.Models;
using EntityFirstAppWeb.Areas.User.Models;
using EntityFirstAppWeb.Areas.Video.Models;
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
                              .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                              .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                              .ForMember(dest => dest.AddedDate, opt => opt.MapFrom(src => src.AddedDate))
                              .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(src => src.ModifiedDate));

            AutoMapper.Mapper.CreateMap<Video, VideoView>();
            AutoMapper.Mapper.CreateMap<Rent, RentView>();

         

            /*AutoMapper Front To Back */
            AutoMapper.Mapper.CreateMap<UserView, User>()
                              .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName))
                              .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                              .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Password))
                              .ForMember(dest => dest.AddedDate, opt => opt.MapFrom(src => src.AddedDate))
                              .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(src => src.ModifiedDate));
            AutoMapper.Mapper.CreateMap<VideoView, Video>();
            AutoMapper.Mapper.CreateMap<RentView, Rent>();
        }
    }
}