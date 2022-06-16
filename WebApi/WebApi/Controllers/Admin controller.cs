using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Admin_controller : ControllerBase
    {

        SprintContext db;
        public Admin_controller(SprintContext _db)
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
    }
}
