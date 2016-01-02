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
    public class RentRepository : RepositoryBase<Rent, AppContext>, IRentRepository 
    {
        private AppContext _context;

        public RentRepository(IDatabaseFactory<AppContext> databaseFactory):base(databaseFactory)
        {
            this._context = new AppContext();
        }
        /// <summary>
        /// Return all Rent.
        /// </summary>
        /// <returns>All Rent.</returns>
        public IEnumerable<Rent> GetAll()
        {
            return Dbset.ToList();
        }
        /// <summary>
        /// Find the Rent by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Transport if found, null if the specified id is not found.</returns>
        public Rent GetRentById(Int64 Id)
        {
            return Dbset.Where(x => x.Id == Id).FirstOrDefault();
        }

        /// <summary>
        /// Add new Transport.
        /// </summary>
        /// <param name="item">The Rent parameter.</param>
        public Rent AddRent(Rent item)
        {
            _context.Rents.Add(item);
            _context.SaveChanges();
            return GetRentById(item.Id);  
        }

        /// <summary>
        /// Delete the Rent.
        /// </summary>
        /// <param name="item">The entity.</param>
        public void DeleteRent(Rent item)
        {

        }

        /// <summary>
        /// Updates existing Rent.
        /// </summary>
        /// <param name="item">The Rent parameter.</param>
        public void UpdateRent(Rent item)
        {
            
        }

     
        /// <summary>
        /// Gets the transports by code.
        /// </summary>
        /// <param name="code">The code identifier.</param>
        /// <returns>Rent if found, null if the specified code is not found.</returns>
        public Rent GetRentByCode(string code)
        {
            return null;
        }

    }
}
