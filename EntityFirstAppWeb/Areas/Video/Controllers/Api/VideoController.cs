using AutoMapper;
using EntityFirstAppService.Service_Interface;
using EntityFirstAppWeb.Areas.Video.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EntityFirstAppWeb.Areas.Video.Controllers.Api
{
    public class VideoController : ApiController
    {
        private readonly IVideoService videoService; 
 
        public VideoController(IVideoService _videoService) 
        {
            this.videoService = _videoService;
        }

        public IEnumerable<VideoView> GetAllUser()
        {
            IEnumerable<EntityFirstApp.Model.Video> videos = this.videoService.GetAll();

            IEnumerable<VideoView> mappedVideos = Mapper.Map<IEnumerable<VideoView>>(videos); 

            return mappedVideos;
        }
    }
}
