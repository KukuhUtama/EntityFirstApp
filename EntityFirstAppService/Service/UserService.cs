﻿using EntityFirstApp;
using EntityFirstApp.Repository_Interface;
using EntityFirstAppService.Service_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstAppService.Service
{
    public class UserService : IUserService
    {

        private readonly IUserRepository userRepository;

        public UserService(IUserRepository _userRepository)
        {
            this.userRepository = _userRepository;
        }
        /// <summary>
        /// Return all User.
        /// </summary>
        /// <returns>All User.</returns>
        IEnumerable<User> GetAll()
        {
            return userRepository.GetAll();
        }

        /// <summary>
        /// Find the User by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Transport if found, null if the specified id is not found.</returns>
        User GetUserById(Guid id)
        {
            return null;
        }

        /// <summary>
        /// Add new Transport.
        /// </summary>
        /// <param name="item">The User parameter.</param>
        void AddUser(User item)
        {

        }

        /// <summary>
        /// Delete the User.
        /// </summary>
        /// <param name="item">The entity.</param>
        void DeleteUser(User item)
        {

        }

        /// <summary>
        /// Updates existing User.
        /// </summary>
        /// <param name="item">The User parameter.</param>
        void UpdateUser(User item)
        {

        }

        /// <summary>
        /// Gets the transports by company identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>User if found, null if the specified CompanyId is not found.</returns>
        User GetUserByCompanyId(Guid id)
        {
            return null;
        }

        /// <summary>
        /// Gets the transports by code.
        /// </summary>
        /// <param name="code">The code identifier.</param>
        /// <returns>User if found, null if the specified code is not found.</returns>
        User GetUserByCode(string code)
        {
            return null;
        }
    }
}