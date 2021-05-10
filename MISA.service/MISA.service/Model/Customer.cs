using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.service.Model
{
    public class Customer
    {

        public Guid customerId { get; set; }
        public string customerCode { get; set; }
        public string  fullname { get; set; }
        public int gender { get; set; }
        public string  email { get; set; }
        public DateTime birthday { get; set; }
        public string address { get; set; }
        public string customerGroupName { get; set; }
        public string status { get; set; }

       public static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer()
                {
                    customerId = Guid.NewGuid(),
                    customerCode = "KH001",
                    fullname = "Nguyen Van An",
                    gender = 0,
                    email = "example@gmail.com",
                    birthday = DateTime.Now,
                    address = "Ha Noi",
                    customerGroupName = "VIP",
                    status = null
                },
                   new Customer()
                {
                    customerId = Guid.NewGuid(),
                    customerCode = "KH002",
                    fullname = "Nguyen Duc hung",
                    gender = 1,
                    email = "example@gmail.com",
                    birthday = DateTime.Now,
                    address = "Ha Noi",
                    customerGroupName = "VIP",
                    status = null
                },
                      new Customer()
                {
                    customerId = Guid.NewGuid(),
                    customerCode = "KH003",
                    fullname = "Tran Van Do",
                    gender = 2,
                    email = "example@gmail.com",
                    birthday = DateTime.Now,
                    address = "Ha Noi",
                    customerGroupName = "VIP",
                    status = null
                }
            };
            return customers;
        }
    }
 
}
