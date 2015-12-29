using EntityFirstApp.Base;
using EntityFirstApp.Context;
using EntityFirstApp.IContext;
using EntityFirstApp.Model;
using EntityFirstApp.Repository_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstApp.Repository
{
    public class VideoRepository : RepositoryBase<Video,AppContext>, IVideoRepository
    {
        private AppContext _context;


        public VideoRepository(IDatabaseFactory<AppContext> databaseFactory)
            : base(databaseFactory)
        {
            this._context = new AppContext();
        }

        /// <summary>
        /// Return all Video.
        /// </summary>
        /// <returns>All Video.</returns>
        public IEnumerable<Video> GetAll()
        {
            return Dbset.ToList();
        }
        //public virtual IEnumerable<T> GetAll()
        //{
        //    return Dbset.ToList();
        //}
        /// <summary>
        /// Find the Video by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Video if found, null if the specified id is not found.</returns>
        public Video GetVideoById(Int64 Id)
        {
            return Dbset.Where(x => x.Id == Id).FirstOrDefault();
        }

        /// <summary>
        /// Add new Video.
        /// </summary>
        /// <param name="item">The Video parameter.</param>
        public Video AddVideo(Video item)
        {
            _context.Videos.Add(item);
            _context.SaveChanges();
            Int64 Id = item.Id;
            return GetVideoById(Id);
        }

        /// <summary>
        /// Delete the Video.
        /// </summary>
        /// <param name="item">The entity.</param>
        public void DeleteVideo(Int64 Id)
        {
            Video video = GetVideoById(Id);
            _context.Videos.Attach(video);
            _context.Videos.Remove(video);
            _context.SaveChanges();
        }

        /// <summary>
        /// Updates existing Video.
        /// </summary>
        /// <param name="item">The Video parameter.</param>
        public void UpdateVideo(Video video)
        {
        }

        /// <summary>
        /// Gets the transports by code.
        /// </summary>
        /// <param name="code">The code identifier.</param>
        /// <returns>Video if found, null if the specified code is not found.</returns>
        public Video GetVideoByCode(string code)
        {
            return null;
        }
    }
}
