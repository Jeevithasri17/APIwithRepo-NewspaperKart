using NewspaperAPI.CTSModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewspaperAPI.Repository
{
    public class NewspaperRepo : INewspaperRepo<Newspapertbl>
    {
        private readonly INewspapertbl<Newspapertbl> o_obj;
        public NewspaperRepo(INewspapertbl<Newspapertbl> _o_obj)
        {
            o_obj = _o_obj;
        }
        public async Task<int> AddNewspaper(Newspapertbl o)
        {
            return await o_obj.AddNewspaper(o);
        }

        public async Task<int> DeleteNewspaper(Newspapertbl o)
        {
            return await o_obj.DeleteNewspaper(o);
        }

        public async Task<int> UpdateNewspaper(Newspapertbl o)
        {
            return await o_obj.UpdateNewspaper(o);
        }

        public async Task<List<Newspapertbl>> GetAllNewspapers()
        {
            return await o_obj.GetAllNewspapers();
        }

        public async Task<Newspapertbl> GetNewspaperById(int id)
        {
            return await o_obj.GetNewspaperById(id);
        }
    }
}
