using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Homecontroller : ControllerBase
    {

        public List<Etable> Get()
        {
            sampledb2Context db = new sampledb2Context();
            return db.Etables.ToList();

        }
    }
}