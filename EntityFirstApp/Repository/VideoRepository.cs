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
        public Video GetVideoById(Guid id)
        {
            return null;
        }

        /// <summary>
        /// Add new Video.
        /// </summary>
        /// <param name="item">The Video parameter.</param>
        public void AddVideo(Video item)
        {

        }

        /// <summary>
        /// Delete the Video.
        /// </summary>
        /// <param name="item">The entity.</param>
        public void DeleteVideo(Video item)
        {

        }

        /// <summary>
        /// Updates existing Video.
        /// </summary>
        /// <param name="item">The Video parameter.</param>
        public void UpdateVideo(Video item)
        {

        }

        /// <summary>
        /// Gets the transports by company identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Video if found, null if the specified CompanyId is not found.</returns>
        public Video GetVideoByCompanyId(Guid id)
        {
            return null;
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
