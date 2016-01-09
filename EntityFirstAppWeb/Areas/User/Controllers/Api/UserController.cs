using AutoMapper;
using EntityFirstAppMisc;
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

        [HttpGet]
        [ActionName("GetAllUser")]
        public IEnumerable<UserView> GetAllUser()
        {
            IEnumerable<EntityFirstApp.User> users = this._userService.GetAll();

            IEnumerable<UserView> mappedUsers = Mapper.Map<IEnumerable<UserView>>(users);

            return mappedUsers;
        }

        [HttpPost]
        [ActionName("DeleteUser")]
        public Response<UserView> DeleteUser(Int64 Id)
        {
            if (this._userService.DeleteUser(Id) == true)
            {
                //// build response
                var response = new Response<UserView> { Model = { } };
                response.Messages.Add(new Message
                {
                    MessageType = MessageType.Success,
                    Value = "User Has Been Deleted"
                });

                return response;
            }
            else
            {
                //// build response
                var response = new Response<UserView> { Model = { } };
                response.Messages.Add(new Message
                {
                    MessageType = MessageType.Warning,
                    Value = "User Has Reference(s) In Renting"
                });

                return response;
            }
        
        }


        [HttpPost]
        [ActionName("AddUser")]
        public Response<UserView> AddUser(UserView user)
        {
            EntityFirstApp.User mappedUser = Mapper.Map <EntityFirstApp.User>(user); 

            var entityUser = this._userService.AddUser(mappedUser);

            UserView userView = Mapper.Map<UserView>(entityUser);

            //// build response
            var response = new Response<UserView> { Model = userView };

            response.Messages.Add(new Message
            {
                MessageType = MessageType.Success,
                Value = "Success"
            });

            return response;
        }

      
    }
}
