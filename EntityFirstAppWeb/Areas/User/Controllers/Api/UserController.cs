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
           return (IEnumerable<UserView>) this._userService.GetAll();
            
        }
    }
}
