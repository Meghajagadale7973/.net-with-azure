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
        [HttpGet]
        public List<Etable> Get()
        {

            sampledb2Context db = new sampledb2Context();
            return db.Etables.ToList();
        }
            [HttpPost]
            public string Post([FromBody]string sample)
            {
                sampledb2Context db = new sampledb2Context();
                Etable e = new Etable();
                e.Fname = sample;
                db.Etables.Add(e);
               db.SaveChanges();
                return "Success";
            }

       [ HttpPut]
        public string Put([FromBody] Etable esample)
        {
            sampledb2Context db = new sampledb2Context();
            var etblsampleObj = db.Etables.Where(x => x.Id == esample.Id);
            if (etblsampleObj != null)
            {
                db.Update(esample);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }

        [HttpDelete]
        public string Delete([FromBody] int Id)
        {
            sampledb2Context db= new sampledb2Context();
            var tblsampleObj = db.Etables.Where(x => x.Id == Id).FirstOrDefault();
            if (tblsampleObj != null)
            {
                db.Etables.Remove(tblsampleObj);
                db.SaveChanges();
                return "Success";
            }

            return "Fail";
        }

    }
}




              