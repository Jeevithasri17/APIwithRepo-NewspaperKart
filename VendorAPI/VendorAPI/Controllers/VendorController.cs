using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendorAPI.CTSModel;
using VendorAPI.Service;

namespace VendorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        private readonly NewspaperContext db;
        public VendorController(NewspaperContext _db)

        {
            db = _db;
        }

        private readonly IVendorServ<Vendortbl> o_serv;
        public VendorController(IVendorServ<Vendortbl> _o_serv)
        {
            o_serv = _o_serv;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllVendor()
        {
            //return Ok(await db.Vendortbls.ToListAsync());
            return Ok(await o_serv.GetAllVendor());

        }
        [HttpPost]
        public async Task<IActionResult> AddVendor(Vendortbl o)
        {
            //db.Vendortbls.Add(c);
            //await db.SaveChangesAsync();
            //return Ok();
            return Ok(await o_serv.AddVendor(o));

        }
        [HttpPut]
        public async Task<IActionResult> UpdateVendor(int id, Vendortbl o)
        {
            //db.Entry(c).State = EntityState.Modified;
            //await db.SaveChangesAsync();
            //return Ok();
            return Ok(await o_serv.UpdateVendor(o));

        }

        [HttpDelete]
        public async Task<IActionResult> DeleteVendor(int id, Vendortbl o)
        {
            //Vendortbl c = db.Vendortbls.Find(id);
            //db.Vendortbls.Remove(c);
            //await db.SaveChangesAsync();
            //return Ok();
            return Ok(await o_serv.DeleteVendor(o));

        }

        [HttpGet]
        [Route("id")]
        public async Task<ActionResult<Vendortbl>> GetVendorById(int id)
        {
            //Vendortbl c = await db.Vendortbls.FindAsync(id);
            //return Ok(c);
            return Ok(await o_serv.GetVendorById(id));

        }
    }
}
