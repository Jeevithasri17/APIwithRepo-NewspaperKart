using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable disable

namespace CustomerAPI.CTSModel
{
    public partial class Customertbl : ICustomertbl<Customertbl>
    {
    
        private readonly NewspaperContext ncc = new NewspaperContext();

        public Customertbl()
        {
            AddDeliverytbls = new HashSet<AddDeliverytbl>();
            Feedbacktbls = new HashSet<Feedbacktbl>();
            Subscriptiontbls = new HashSet<Subscriptiontbl>();
        }

        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phoneno { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public virtual ICollection<AddDeliverytbl> AddDeliverytbls { get; set; }
        public virtual ICollection<Feedbacktbl> Feedbacktbls { get; set; }
        public virtual ICollection<Subscriptiontbl> Subscriptiontbls { get; set; }

        public async Task<int> AddCustomer(Customertbl o)
        {
            ncc.Customertbls.Add(o);
            return await ncc.SaveChangesAsync();
        }

        public async Task<int> DeleteAccount(Customertbl o)
        {
            ncc.Customertbls.Remove(o);
            return await ncc.SaveChangesAsync();
        }

        public async Task<int> UpdateAccount(Customertbl o)
        {
            using (var nc = new NewspaperContext())
            {
                nc.Entry(o).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return (await nc.SaveChangesAsync());
            }
        }

        public async Task<List<Customertbl>> GetAllCustomer()
        {
            return await ncc.Customertbls.ToListAsync();
        }

        public async Task<Customertbl> GetAccById(int id)
        {
            return await ncc.Customertbls.FindAsync(id);
        }
    }
}
