using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Product : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float Weight { get; set; }
        public float Size { get; set; }
        public decimal Value { get; set; }
        public string RFID { get; set; }
    }
}
