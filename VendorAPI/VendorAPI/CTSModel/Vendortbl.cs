using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable disable

namespace VendorAPI.CTSModel
{
    public partial class Vendortbl:IVendortbl<Vendortbl>
    {

        private readonly NewspaperContext ncc = new NewspaperContext();

        public int VendorId { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Phoneno { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public async Task<int> AddVendor(Vendortbl o)
        {
            ncc.Vendortbls.Add(o);
            return await ncc.SaveChangesAsync();
        }

        public async Task<int> DeleteVendor(Vendortbl o)
        {
            ncc.Vendortbls.Remove(o);
            return await ncc.SaveChangesAsync();
        }

        public async Task<int> UpdateVendor(Vendortbl o)
        {
            using (var nc = new NewspaperContext())
            {
                nc.Entry(o).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return (await nc.SaveChangesAsync());
            }
        }

        public async Task<List<Vendortbl>> GetAllVendor()
        {
            return await ncc.Vendortbls.ToListAsync();
        }

        public async Task<Vendortbl> GetVendorById(int id)
        {
            return await ncc.Vendortbls.FindAsync(id);
        }
    }
}
