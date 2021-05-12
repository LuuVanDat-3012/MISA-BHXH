using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.service.Model
{
    public class CustomerDTO
    {
        public string CustomerCode { get; set; }
        public string Fullname { get; set; }
        public int Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Guid CustomerGroupId { get; set; }
        public string Status { get; set; }
        public string MemberCardCode { get; set; }
        public string TaxCode { get; set; }
    }
}
