using EntityFirstApp.Model;
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
        public IEnumerable<Rent> GetAll()
        {
            return rentRepository.GetAll();
        }

        public Rent GetRentById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Rent AddRent(Rent item)
        {
            return rentRepository.AddRent(item);
        }

        public void DeleteRent(Rent item)
        {
            throw new NotImplementedException();
        }

        public void UpdateRent(Rent item)
        {
            throw new NotImplementedException();
        }

        public EntityFirstApp.Model.Rent GetRentByCode(string code)
        {
            throw new NotImplementedException();
        }
    }
}
