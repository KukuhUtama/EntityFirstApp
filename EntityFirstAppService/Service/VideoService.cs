using EntityFirstApp.Model;
using EntityFirstApp.Repository_Interface;
using EntityFirstAppService.Service_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstAppService.Service
{
    public class VideoService : IVideoService
    {

        private readonly IVideoRepository videoRepository;

        public VideoService(IVideoRepository _videoRepository)
        {
            this.videoRepository = _videoRepository;
        }

        public IEnumerable<Video> GetAll()
        {
            return videoRepository.GetAll();
        }

        public Video GetVideoById(Int64 Id)
        {
            return videoRepository.GetVideoById(Id);
        }

        public Video AddVideo(Video item)
        {
            return videoRepository.AddVideo(item);
        }

        public void DeleteVideo(Int64 Id)
        {
            videoRepository.DeleteVideo(Id);
        }

        public void UpdateVideo(Video item)
        {
            throw new NotImplementedException();
        }

        public Video GetVideoByCode(string code)
        {
            throw new NotImplementedException();
        }
    }
}
