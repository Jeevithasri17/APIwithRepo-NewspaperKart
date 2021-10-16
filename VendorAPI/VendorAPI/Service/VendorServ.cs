using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendorAPI.CTSModel;
using VendorAPI.Repository;

namespace VendorAPI.Service
{
    public class VendorServ : IVendorServ<Vendortbl>
    {
        private readonly IVendorRepo<Vendortbl> o_repo;
        public VendorServ(IVendorRepo<Vendortbl> _o_repo)
        {
            o_repo = _o_repo;
        }
        public async Task<int> AddVendor(Vendortbl o)
        {
            return await o_repo.AddVendor(o);
        }

        public async Task<int> DeleteVendor(Vendortbl o)
        {
            return await o_repo.DeleteVendor(o);
        }

        public async Task<int> UpdateVendor(Vendortbl o)
        {
            return await o_repo.UpdateVendor(o);
        }

        public async Task<List<Vendortbl>> GetAllVendor()
        {
            return await o_repo.GetAllVendor();
        }

        public async Task<Vendortbl> GetVendorById(int id)
        {
            return await o_repo.GetVendorById(id);
        }
    }
}
