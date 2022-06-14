using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Home_controller : ControllerBase
    {
        public List<Course> Get()
        {
            sampledb2Context db = new sampledb2Context();
            return db.Courses.ToList();
        }
    }
}
