using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Tenant
    {
        public int TenantID { get; set; }
        public string TenantName { get; set; }
        public string TenantSurname { get; set; }
        public string TenantEmail { get; set; }
        public string TenantPassword { get; set; }
        public int TenantPhone { get; set;  }
        public string TenantStatus { get; set; }

    }
}
