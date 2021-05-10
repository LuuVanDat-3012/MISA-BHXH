using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MISA.service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MISA.service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoReadWriteController : ControllerBase
    {
        // GET: api/<DemoReadWriteController>
        [HttpGet]
        [EnableCors("AnotherPolicy")]
        public ActionServiceResult Get()
        {
            ActionServiceResult aSR = new ActionServiceResult()
            {
                Success = true,
                Message = "Thanh cong",
                MISAcode = Enumeration.MISAcode.Success,
                data = Customer.GetCustomers()
            };
            return aSR;

        }

        // GET api/<DemoReadWriteController>/5
        [HttpGet("{id}")]
        public ActionServiceResult Get(string id)
        {
            ActionServiceResult aSR = new ActionServiceResult()
            {
                Success = true,
                Message = "Thanh cong",
                MISAcode = Enumeration.MISAcode.Success,
                data = Customer.GetCustomers().Where(p => p.customerId.Equals(id)).FirstOrDefault()
            };
            return aSR;
        }

        // POST api/<DemoReadWriteController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DemoReadWriteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DemoReadWriteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
