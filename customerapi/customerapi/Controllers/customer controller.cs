using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerApi.Models;


namespace CustomerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        customerDB1Context db;
        public CustomerController(customerDB1Context _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return db.Customers;
        }

        [HttpPost]
        public string Post([FromBody] Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
            return "success";

        }
    }
}