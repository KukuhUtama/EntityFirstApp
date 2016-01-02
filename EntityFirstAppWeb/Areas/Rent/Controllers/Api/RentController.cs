using AutoMapper;
using EntityFirstAppMisc;
using EntityFirstAppService.Service_Interface;
using EntityFirstAppWeb.Areas.Rent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EntityFirstAppWeb.Areas.Rent.Controllers.Api
{
    public class RentController : ApiController
    {
        private readonly IRentService rentService;

        public RentController(IRentService _rentService)
        {
            this.rentService = _rentService;
        }

        public IEnumerable<RentView> GetAllRent()
        {
            IEnumerable<EntityFirstApp.Model.Rent> rents = this.rentService.GetAll();

            IEnumerable<RentView> mappedRents = Mapper.Map<IEnumerable<RentView>>(rents);

            return mappedRents;
        }

        [HttpPost]
        [ActionName("AddRent")]
        public Response<RentView> AddRent(RentView rent)
        {

            EntityFirstApp.Model.Rent mappedRent = Mapper.Map<EntityFirstApp.Model.Rent>(rent);

            var entityRent = this.rentService.AddRent(mappedRent);

            RentView rentView = Mapper.Map<RentView>(entityRent);

            var response = new Response<RentView> { Model = rentView };

            response.Messages.Add(new Message
            {
                MessageType = MessageType.Success,
                Value = "Success"
            });

            return response;
        }


        [HttpPost]
        [ActionName("GetRentById")]
        public Response<RentView> GetRentById(Int64 Id)
        {

            var entityRent = this.rentService.GetRentById(Id);

            RentView rentView = Mapper.Map<RentView>(entityRent);

            var response = new Response<RentView> { Model = rentView };

            response.Messages.Add(new Message
            {
                MessageType = MessageType.Success,
                Value = "Success"
            });

            return response;
        }

        [HttpPost]
        [ActionName("UpdateRent")]
        public Response<RentView> UpdateRent(RentView rent)
        {

            EntityFirstApp.Model.Rent mappedRent = Mapper.Map<EntityFirstApp.Model.Rent>(rent);

            var entityRent = this.rentService.UpdateRent(mappedRent);

            RentView rentView = Mapper.Map<RentView>(entityRent);

            var response = new Response<RentView> { Model = rentView };

            response.Messages.Add(new Message
            {
                MessageType = MessageType.Success,
                Value = "Success"
            });

            return response;
        }

    }
}
