using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Rentals
    {

        public int RentalID { get; set; }
        public int PropertyAgentID { get; set; }
        public int TenantID { get; set; }
        public DateTime StartDate {get; set;}
        public DateTime EndDate {get; set; }
    }
}
