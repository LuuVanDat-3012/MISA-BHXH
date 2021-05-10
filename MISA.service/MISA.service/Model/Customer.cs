using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.service.Model
{
    public class Customer
    {

        public string Guid { get; set; }
        public string  fullname { get; set; }
        public string  email { get; set; }
        public DateTime birthday { get; set; }
        public string address { get; set; }
        public static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer()
                {
                    customerId = "KH01",
                    fullname = "Luu Van Dat",
                    email = "nguyenvanan@gmail.com",
                    birthday = DateTime.Now,
                    address = "HA Noi"
                },
                 new Customer()
                {
                    customerId = "KH01",
                    fullname = "Luu Van Dat",
                    email = "nguyenvanan@gmail.com",
                    birthday = DateTime.Now,
                    address = "HA Noi"
                },
                  new Customer()
                {
                    customerId = "KH01",
                    fullname = "Luu Van Dat",
                    email = "nguyenvanan@gmail.com",
                    birthday = DateTime.Now,
                    address = "HA Noi"
                }

            };
            return customers;
        }
    }
 
}
