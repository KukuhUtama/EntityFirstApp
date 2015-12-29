using AutoMapper;
using EntityFirstAppMisc;
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
    public class VideoController:ApiController
    {
        private readonly IVideoService videoService; 
 
        public VideoController(IVideoService _videoService) 
        {
            this.videoService = _videoService;
        }

        [HttpGet]
        [ActionName("GetAllVideo")]
        public IEnumerable<VideoView> GetAllVideo()
        {
            IEnumerable<EntityFirstApp.Model.Video> videos = this.videoService.GetAll();

            IEnumerable<VideoView> mappedVideos = Mapper.Map<IEnumerable<VideoView>>(videos); 

            return mappedVideos;
        }

        [HttpPost]
        [ActionName("AddVideo")]
        public Response<VideoView> AddVideo(VideoView video) 
        {
            EntityFirstApp.Model.Video mappedVideo = Mapper.Map<EntityFirstApp.Model.Video>(video);

            var entityVideo = this.videoService.AddVideo(mappedVideo);

            VideoView VideoView = Mapper.Map<VideoView>(entityVideo);

            //// build response
            var response = new Response<VideoView> { Model = VideoView };

            response.Messages.Add(new Message
            {
                MessageType = MessageType.Success,
                Value = "Success"
            });

            return response;
        }


       [HttpPost]
       [ActionName("DeleteVideo")]
       public Response<VideoView> DeleteVideo(Int64 Id)
       {
           var entityVideo = this.videoService.GetVideoById(Id);
           this.videoService.DeleteVideo(Id);

           VideoView videoView = Mapper.Map<VideoView>(entityVideo);

           //// build response
           var response = new Response<VideoView> { Model = videoView };

           response.Messages.Add(new Message
           {
               MessageType = MessageType.Success,
               Value = "Success"
           });

           return response;
       }



    }
}
