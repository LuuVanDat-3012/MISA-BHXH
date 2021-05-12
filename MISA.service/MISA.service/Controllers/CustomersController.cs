using Dapper;
using Microsoft.AspNetCore.Mvc;
using MISA.service.Model;
using MISA.service.Service;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MISA.service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        // GET: api/<CustomersController>
        [HttpGet]
        public ActionServiceResult Get()
        {
            var connectionString = "Host = 127.0.0.1;" +
                "Port = 3306; " +
                "Database = lvdat_misa_cukcuk;" +
                "User Id = root;" +
                "Password = luudet0512ld;" +
                "Character Set=utf8";
            var dbConnection = new MySqlConnection(connectionString);
            var customers = dbConnection.Query<Customer>("select * from customer limit 20").ToList();
            var customerDTOs = CustomerMapper.convertListCustomer(customers);
            return new ActionServiceResult()
            {
                Message = "Thanh cong",
                MISAcode = Enumeration.MISAcode.Success,
                Success = true,
                data = customerDTOs
            };
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public ActionServiceResult Get(string id)
        {
            var connectionString = "Host = localhost;" +
                "Port = 3306; " +
                "Database = lvdat_misa_cukcuk;" +
                "User Id = root;" +
                "Password = lovanmet1;" +
                "Character Set=utf8";
            var dbConnection = new MySqlConnection(connectionString);
            var sqlQuery = $"select * from customer where customerCode = '{id}' ";
            var customers = dbConnection.Query<Customer>(sqlQuery).FirstOrDefault();
            return new ActionServiceResult()
            {
                Message = "Thanh cong",
                MISAcode = Enumeration.MISAcode.Success,
                Success = true,
                data = customers
            };
        }

        // POST api/<CustomersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
