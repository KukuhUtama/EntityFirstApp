using EntityFirstApp;
using EntityFirstAppMisc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstAppService.Service_Interface
{
    public interface IUserService
    {
        /// <summary>
        /// Return all User.
        /// </summary>
        /// <returns>All User.</returns>
         IEnumerable<User> GetAll();

        /// <summary>
        /// Find the User by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Transport if found, null if the specified id is not found.</returns>
         User GetUserById(Int64 Id);

        /// <summary>
        /// Add new Transport.
        /// </summary>
        /// <param name="item">The User parameter.</param>
         User AddUser(User item);

        /// <summary>
        /// Delete the User.
        /// </summary>
        /// <param name="item">The entity.</param>
         Boolean DeleteUser(Int64 Id); 

        /// <summary>
        /// Updates existing User.
        /// </summary>
        /// <param name="item">The User parameter.</param>
         void UpdateUser(User item);

   
        /// <summary>
        /// Gets the transports by code.
        /// </summary>
        /// <param name="code">The code identifier.</param>
        /// <returns>User if found, null if the specified code is not found.</returns>
         User GetUserByCode(string code);
    }
}
