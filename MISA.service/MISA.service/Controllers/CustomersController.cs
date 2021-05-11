﻿using Dapper;
using Microsoft.AspNetCore.Mvc;
using MISA.service.Model;
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
            var customers = dbConnection.Query<Customer>("select * from customer").ToList();
            return new ActionServiceResult()
            {
                Message = "Thanh cong",
                MISAcode = Enumeration.MISAcode.Success,
                Success = true,
                data = customers
            };
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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