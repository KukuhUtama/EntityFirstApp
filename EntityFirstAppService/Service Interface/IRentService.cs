using EntityFirstApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstAppService.Service_Interface
{
    public interface IRentService
    {
        /// <summary>
        /// Return all Rent.
        /// </summary>
        /// <returns>All Rent.</returns>
        IEnumerable<Rent> GetAll();

        /// <summary>
        /// Find the Rent by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Transport if found, null if the specified id is not found.</returns>
        Rent GetRentById(Guid id);

        /// <summary>
        /// Add new Transport.
        /// </summary>
        /// <param name="item">The Rent parameter.</param>
        Rent AddRent(Rent item);

        /// <summary>
        /// Delete the Rent.
        /// </summary>
        /// <param name="item">The entity.</param>
        void DeleteRent(Rent item);

        /// <summary>
        /// Updates existing Rent.
        /// </summary>
        /// <param name="item">The Rent parameter.</param>
        void UpdateRent(Rent item);

        /// <summary>
        /// Gets the transports by code.
        /// </summary>
        /// <param name="code">The code identifier.</param>
        /// <returns>Rent if found, null if the specified code is not found.</returns>
        Rent GetRentByCode(string code); 
    }
}
