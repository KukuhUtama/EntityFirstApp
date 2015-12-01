using AutoMapper;
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
    }
}
