using Dapper;
using Microsoft.AspNetCore.Mvc;
using MISA.service.Data;
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
        public List<CustomerDTO> Get()
        {
            
            
            var dbConnector = new DatabaseConnector<Customer>();
            var customers = dbConnector.GetAll().ToList();
            var customerDTOs = CustomerMapper.convertListCustomer(customers);
            return customerDTOs;
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public ActionServiceResult Get(string id)
        {
          
            var sqlQuery = $"select * from customer where customerCode = '{id}' ";
            var customers = DAL.GetConnection().Query<Customer>(sqlQuery).ToList();
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
        public int Post([FromBody] Customer customer)
        {
            var sqlQuery = $"INSERT INTO customer(CustomerId, CustomerCode, Fullname, Phone) VALUES(" +
                $"'{Guid.NewGuid().ToString()}'," +
                $"'{customer.CustomerCode.ToString()}'," +
                $"'{customer.Fullname.ToString()}'," +
                $"'{customer.Phone.ToString()}')";
            DAL.GetConnection().Execute(sqlQuery);
            return 1;
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
