using EntityFirstApp.Repository_Interface;
using EntityFirstAppService.Service_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstAppService.Service
{
    public class RentService : IRentService 
    {

        private readonly IRentRepository rentRepository;
        public RentService(IRentRepository _rentRepository)
        {
            this.rentRepository = _rentRepository;
        }
        public IEnumerable<EntityFirstApp.Model.Rent> GetAll()
        {
            return rentRepository.GetAll();
        }

        public EntityFirstApp.Model.Rent GetRentById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void AddRent(EntityFirstApp.Model.Rent item)
        {
            throw new NotImplementedException();
        }

        public void DeleteRent(EntityFirstApp.Model.Rent item)
        {
            throw new NotImplementedException();
        }

        public void UpdateRent(EntityFirstApp.Model.Rent item)
        {
            throw new NotImplementedException();
        }

        public EntityFirstApp.Model.Rent GetRentByCode(string code)
        {
            throw new NotImplementedException();
        }
    }
}
