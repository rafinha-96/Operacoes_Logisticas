using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class StoreHistory : BaseModel
    {
        public DateTime Date { get; set; }
        public StoreRequest StoreRequest { get; set; }

    }
}
