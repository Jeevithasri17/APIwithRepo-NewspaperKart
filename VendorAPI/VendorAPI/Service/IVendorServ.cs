using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendorAPI.Service
{
    public interface IVendorServ<Vendortbl>
    {
        public Task<int> AddVendor(Vendortbl o);
        public Task<Vendortbl> GetVendorById(int id);
        public Task<int> UpdateVendor(Vendortbl o);
        public Task<int> DeleteVendor(Vendortbl o);
        public Task<List<Vendortbl>> GetAllVendor();
    }
}
