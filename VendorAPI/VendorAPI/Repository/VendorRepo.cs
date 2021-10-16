using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendorAPI.CTSModel;

namespace VendorAPI.Repository
{
    public class VendorRepo : IVendorRepo<Vendortbl>
    {
        private readonly IVendortbl<Vendortbl> o_obj;
        public VendorRepo(IVendortbl<Vendortbl> _o_obj)
        {
            o_obj = _o_obj;
        }
        public async Task<int> AddVendor(Vendortbl o)
        {
            return await o_obj.AddVendor(o);
        }

        public async Task<int> DeleteVendor(Vendortbl o)
        {
            return await o_obj.DeleteVendor(o);
        }

        public async Task<int> UpdateVendor(Vendortbl o)
        {
            return await o_obj.UpdateVendor(o);
        }

        public async Task<List<Vendortbl>> GetAllVendor()
        {
            return await o_obj.GetAllVendor();
        }

        public async Task<Vendortbl> GetVendorById(int id)
        {
            return await o_obj.GetVendorById(id);
        }
    }
}
