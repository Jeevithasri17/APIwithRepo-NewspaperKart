using CustomerAPI.CTSModel;
using CustomerAPI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly NewspaperContext db;
        public CustomerController(NewspaperContext _db)

        {
            db = _db;
        }

        private readonly ICustomerServ<Customertbl> o_serv;
        public CustomerController(ICustomerServ<Customertbl> _o_serv)
        {
            o_serv = _o_serv;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCustomer()
        {
            //return Ok(await db.Customertbls.ToListAsync());
            return Ok(await o_serv.GetAllCustomer());

        }
        [HttpPost]
        public async Task<IActionResult> AddCustomer(Customertbl o)
        {
            //db.Customertbls.Add(c);
            //await db.SaveChangesAsync();
            //return Ok();
            return Ok(await o_serv.AddCustomer(o));

        }
        [HttpPut]
        public async Task<IActionResult> UpdateAccount(int id, Customertbl o)
        {

            //db.Entry(c).State = EntityState.Modified;
            //await db.SaveChangesAsync();
            //return Ok();
            return Ok(await o_serv.UpdateAccount(o));

        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAccount(int id, Customertbl o)
        {
            //Customertbl c = db.Customertbls.Find(id);
            //db.Customertbls.Remove(c);
            //await db.SaveChangesAsync();
            //return Ok();
            return Ok(await o_serv.DeleteAccount(o));

        }

        [HttpGet]
        [Route("id")]
        public async Task<ActionResult<Customertbl>> GetAccById(int id)
        {
            //Customertbl c = await db.Customertbls.FindAsync(id);
            //return Ok(c);
            return Ok(await o_serv.GetAccById(id));

        }
    }
}
