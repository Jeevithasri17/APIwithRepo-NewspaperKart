using CustomerAPI.CTSModel;
using CustomerAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAPI.Service
{
    public class CustomerServ : ICustomerServ<Customertbl>
    {
        private readonly ICustomerRepo<Customertbl> o_repo;
        public CustomerServ(ICustomerRepo<Customertbl> _o_repo)
        {
            o_repo = _o_repo;
        }
        public async Task<int> AddCustomer(Customertbl o)
        {
            return await o_repo.AddCustomer(o);
        }

        public async Task<int> DeleteAccount(Customertbl o)
        {
            return await o_repo.DeleteAccount(o);
        }

        public async Task<int> UpdateAccount(Customertbl o)
        {
            return await o_repo.UpdateAccount(o);
        }

        public async Task<List<Customertbl>> GetAllCustomer()
        {
            return await o_repo.GetAllCustomer();
        }

        public async Task<Customertbl> GetAccById(int id)
        {
            return await o_repo.GetAccById(id);
        }
    }
}
