using EntityFirstAppService.Service_Interface;
using EntityFirstAppWeb.Areas.User.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EntityFirstAppWeb.Areas.User.Controllers.Api
{
    public class UserController : ApiController
    {

        private readonly IUserService _userService;
 
        public UserController(IUserService userService)
        {
            this._userService = userService;
        }
    
      
        public IEnumerable<UserView> GetAllUser()
        {
            //IEnumerable<User> users = this._userService.GetAll();

            //IEnumerable<User> mappedUsers = Mapper.Map<IEnumerable<User>>(users);

            //return mappedUsers;
            //return this._userService.GetAll();
            return null;
            
        }
    }
}
