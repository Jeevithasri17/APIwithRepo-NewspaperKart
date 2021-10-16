using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable disable

namespace NewspaperAPI.CTSModel
{
    public partial class Newspapertbl:INewspapertbl<Newspapertbl>
    {
        private readonly NewspaperContext ncc = new NewspaperContext();

        public Newspapertbl()
        {
            AddDeliverytbls = new HashSet<AddDeliverytbl>();
            Feedbacktbls = new HashSet<Feedbacktbl>();
            Subscriptiontbls = new HashSet<Subscriptiontbl>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public string Price { get; set; }

        public virtual ICollection<AddDeliverytbl> AddDeliverytbls { get; set; }
        public virtual ICollection<Feedbacktbl> Feedbacktbls { get; set; }
        public virtual ICollection<Subscriptiontbl> Subscriptiontbls { get; set; }

        public async Task<int> AddNewspaper(Newspapertbl o)
        {
            ncc.Newspapertbls.Add(o);
            return await ncc.SaveChangesAsync();
        }

        public async Task<int> DeleteNewspaper(Newspapertbl o)
        {
            ncc.Newspapertbls.Remove(o);
            return await ncc.SaveChangesAsync();
        }

        public async Task<int> UpdateNewspaper(Newspapertbl o)
        {
            using (var nc = new NewspaperContext())
            {
                nc.Entry(o).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                return (await nc.SaveChangesAsync());
            }
        }

        public async Task<List<Newspapertbl>> GetAllNewspapers()
        {
            return await ncc.Newspapertbls.ToListAsync();
        }

        public async Task<Newspapertbl> GetNewspaperById(int id)
        {
            return await ncc.Newspapertbls.FindAsync(id);
        }

    }
}
