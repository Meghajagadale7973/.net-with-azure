using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi1.Models;

namespace WebApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class User_Controller : ControllerBase
    {


        EcommerceDBContext db;
        public User_Controller(EcommerceDBContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return db.Users;
        }

        [HttpPost]
        public string Post([FromBody] User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return "success";
        }
        [HttpPut]
        public string Put([FromBody] User tbluser)
        {
            var tbluserObj = db.Users.Where(x => x.Id == tbluser.Id);
            if (tbluserObj != null)
            {
                db.Users.Update(tbluser);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }



        [HttpDelete]
        public string Delete([FromBody] int Id)
        {
            var tbluserObj = db.Users.Where(x => x.Id == Id).FirstOrDefault();
            if (tbluserObj != null)
            {
                db.Users.Remove(tbluserObj);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }






    }
}
