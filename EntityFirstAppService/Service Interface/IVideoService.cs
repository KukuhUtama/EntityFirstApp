using EntityFirstApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstAppService.Service_Interface
{
    public interface IVideoService
    {
        /// <summary>
        /// Return all Video.
        /// </summary>
        /// <returns>All Video.</returns>
        IEnumerable<Video> GetAll();

        /// <summary>
        /// Find the Video by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Transport if found, null if the specified id is not found.</returns>
        Video GetVideoById(Guid id);

        /// <summary>
        /// Add new Transport.
        /// </summary>
        /// <param name="item">The Video parameter.</param>
        void AddVideo(Video item);

        /// <summary>
        /// Delete the Video.
        /// </summary>
        /// <param name="item">The entity.</param>
        void DeleteVideo(Video item);

        /// <summary>
        /// Updates existing Video.
        /// </summary>
        /// <param name="item">The Video parameter.</param>
        void UpdateVideo(Video item);

        /// <summary>
        /// Gets the transports by company identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Video if found, null if the specified CompanyId is not found.</returns>
        Video GetVideoByCompanyId(Guid id);

        /// <summary>
        /// Gets the transports by code.
        /// </summary>
        /// <param name="code">The code identifier.</param>
        /// <returns>Video if found, null if the specified code is not found.</returns>
        Video GetVideoByCode(string code);
    }   
}
