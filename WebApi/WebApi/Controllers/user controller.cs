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
    public class user_controller : ControllerBase
    {
        SprintContext db;
        public user_controller(SprintContext _db)
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
    }
}