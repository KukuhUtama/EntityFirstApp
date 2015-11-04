using EntityFirstApp.Base;
using EntityFirstApp.Context;
using EntityFirstApp.Repository_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstApp.Repository
{
    //public class UserRepository : RepositoryBase<DbContextEF>, ICustomerRepository
    //RepositoryBase<ORS_Applicant, ApplicantContext>, IApplicantRepository
    public class UserRepository: RepositoryBase<User, AppContext>, IUserRepository
    {

        //Focus in here
        //In here should be extend method besides RepositoryBase method.

        public UserRepository() : base ()
        {
           
        }

        /// <summary>
        /// Return all User.
        /// </summary>
        /// <returns>All User.</returns>
        public IEnumerable<User> GetAll()
        {
            return this.GetAll();
        }

        /// <summary>
        /// Find the User by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>User if found, null if the specified id is not found.</returns>
        public User GetUserById(Guid id)
        {
            return null;
        }

        /// <summary>
        /// Add new User.
        /// </summary>
        /// <param name="item">The User parameter.</param>
        public void AddUser(User item)
        {
           
        }

        /// <summary>
        /// Delete the User.
        /// </summary>
        /// <param name="item">The entity.</param>
        public void DeleteUser(User item)
        {

        }

        /// <summary>
        /// Updates existing User.
        /// </summary>
        /// <param name="item">The User parameter.</param>
        public void UpdateUser(User item)
        {
           
        }

        /// <summary>
        /// Gets the transports by company identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>User if found, null if the specified CompanyId is not found.</returns>
        public User GetUserByCompanyId(Guid id)
        {
            return null;
        }

        /// <summary>
        /// Gets the transports by code.
        /// </summary>
        /// <param name="code">The code identifier.</param>
        /// <returns>User if found, null if the specified code is not found.</returns>
        public User GetUserByCode(string code)
        {
            return null;
        }
    }
}
