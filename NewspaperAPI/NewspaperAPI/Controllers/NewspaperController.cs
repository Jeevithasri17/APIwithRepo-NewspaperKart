using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewspaperAPI.CTSModel;
using NewspaperAPI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewspaperAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewspaperController : ControllerBase
    {
        private readonly NewspaperContext db;
        public NewspaperController(NewspaperContext _db)

        {
            db = _db;
        }

        private readonly INewspaperServ<Newspapertbl> o_serv;
        public NewspaperController(INewspaperServ<Newspapertbl> _o_serv)
        {
            o_serv = _o_serv;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllNewspapers()
        {
            //return Ok(await db.Newspapertbls.ToListAsync());
            return Ok(await o_serv.GetAllNewspapers());

        }
        [HttpPost]
        public async Task<IActionResult> AddNewspaper(Newspapertbl o)
        {
            //db.Newspapertbls.Add(c);
            //await db.SaveChangesAsync();
            //return Ok();
            return Ok(await o_serv.AddNewspaper(o));

        }
        [HttpPut]
        public async Task<IActionResult> UpdateNewspaper(int id, Newspapertbl o)
        {
            //db.Entry(c).State = EntityState.Modified;
            //await db.SaveChangesAsync();
            //return Ok();
            return Ok(await o_serv.UpdateNewspaper(o));

        }

        [HttpDelete]
        public async Task<IActionResult> DeleteNewspaper(int id, Newspapertbl o)
        {
            //Newspapertbl c = db.Newspapertbls.Find(id);
            //db.Newspapertbls.Remove(c);
            //await db.SaveChangesAsync();
            //return Ok();
            return Ok(await o_serv.DeleteNewspaper(o));

        }

        [HttpGet]
        [Route("id")]
        public async Task<ActionResult<Newspapertbl>> GetNewspaperById(int id)
        {
            //Newspapertbl c = await db.Newspapertbls.FindAsync(id);
            //return Ok(c);
            return Ok(await o_serv.GetNewspaperById(id));

        }
    }
}
