using CustomerAPI.CTSModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAPI.Repository
{
    public class CustomerRepo:ICustomerRepo<Customertbl>
    {
        private readonly ICustomertbl<Customertbl> o_obj;
        public CustomerRepo(ICustomertbl<Customertbl> _o_obj)
        {
            o_obj = _o_obj;
        }
        public async Task<int> AddCustomer(Customertbl o)
        {
            return await o_obj.AddCustomer(o);
        }

        public async Task<int> DeleteAccount(Customertbl o)
        {
            return await o_obj.DeleteAccount(o);
        }

        public async Task<int> UpdateAccount(Customertbl o)
        {
            return await o_obj.UpdateAccount(o);
        }

        public async Task<List<Customertbl>> GetAllCustomer()
        {
            return await o_obj.GetAllCustomer();
        }

        public async Task<Customertbl> GetAccById(int id)
        {
            return await o_obj.GetAccById(id);
        }
    }
}
