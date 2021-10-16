using NewspaperAPI.CTSModel;
using NewspaperAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewspaperAPI.Service
{
    public class NewspaperServ : INewspaperServ<Newspapertbl>
    {
        private readonly INewspaperRepo<Newspapertbl> o_repo;
        public NewspaperServ(INewspaperRepo<Newspapertbl> _o_repo)
        {
            o_repo = _o_repo;
        }
        public async Task<int> AddNewspaper(Newspapertbl o)
        {
            return await o_repo.AddNewspaper(o);
        }

        public async Task<int> DeleteNewspaper(Newspapertbl o)
        {
            return await o_repo.DeleteNewspaper(o);
        }

        public async Task<int> UpdateNewspaper(Newspapertbl o)
        {
            return await o_repo.UpdateNewspaper(o);
        }

        public async Task<List<Newspapertbl>> GetAllNewspapers()
        {
            return await o_repo.GetAllNewspapers();
        }

        public async Task<Newspapertbl> GetNewspaperById(int id)
        {
            return await o_repo.GetNewspaperById(id);
        }
    }
}
