using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewspaperAPI.Repository
{
    public interface INewspaperRepo<Newspapertbl>
    {
        public Task<int> AddNewspaper(Newspapertbl o);
        public Task<Newspapertbl> GetNewspaperById(int id);
        public Task<int> UpdateNewspaper(Newspapertbl o);
        public Task<int> DeleteNewspaper(Newspapertbl o);
        public Task<List<Newspapertbl>> GetAllNewspapers();
    }
}
