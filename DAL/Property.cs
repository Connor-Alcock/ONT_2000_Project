using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Property
    {
        public int PropertyID { get; set; }
        public string PropertyDescription { get; set; }
        public byte[] Picture { get; set; }
        public int PropertyPrice { get; set; }
        public int PropertyTypeID { get; set; }
        public string PropertyStatus { get; set; }
        public int SuburbID { get; set; }
    }
}
