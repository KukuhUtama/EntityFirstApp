﻿using EntityFirstApp;
using EntityFirstApp.Repository_Interface;
using EntityFirstAppMisc;
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
        public IEnumerable<User> GetAll()
        {
            return userRepository.GetAll();
        }

        /// <summary>
        /// Find the User by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Transport if found, null if the specified id is not found.</returns>
        public User GetUserById(Int64 Id)
        {
            return this.userRepository.GetUserById(Id);   
        }

        /// <summary>
        /// Add new Transport.
        /// </summary>
        /// <param name="item">The User parameter.</param>
        
        public User AddUser(User user)
        {
            return this.userRepository.AddUser(user);
        }

        /// <summary>
        /// Delete the User.
        /// </summary>
        /// <param name="item">The entity.</param>
        public Boolean DeleteUser(Int64 Id)
        {
            if (this.userRepository.IsUserHasRent(Id) == true)
            {
                return false;
            }
            else
            {
                this.userRepository.DeleteUser(Id);
                return true;
            }
        }

        /// <summary>
        /// Updates existing User.
        /// </summary>
        /// <param name="item">The User parameter.</param>
        public void UpdateUser(User item)
        {

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
