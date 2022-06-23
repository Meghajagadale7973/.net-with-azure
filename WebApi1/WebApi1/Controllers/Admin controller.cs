using WebApi1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Admin_Controller : ControllerBase
    {
        EcommerceDBContext db;
        public Admin_Controller(EcommerceDBContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<Admin> Get()
        {
            return db.Admins;
        }

        [HttpPost]
        public string Post([FromBody] Admin admin)
        {
            db.Admins.Add(admin);
            db.SaveChanges();
            return "success";
        }
        [HttpPut]
        public string Put([FromBody] Admin tbladmin)
        {
            var tbladminObj = db.Users.Where(x => x.Id == tbladmin.Id);
            if (tbladminObj != null)
            {
                db.Admins.Update(tbladmin);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }



        [HttpDelete]
        public string Delete([FromBody] int Id)
        {
            var tbladminObj = db.Admins.Where(x => x.Id == Id).FirstOrDefault();
            if (tbladminObj != null)
            {
                db.Admins.Remove(tbladminObj);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }








    }
}
