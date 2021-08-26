using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Store : BaseModel
    {
        public string Name { get; set; }
        //public Product Product{ get; set; }
        public int Quantity { get; set; }
        //public Status status { get; set; }
    }
}
