using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Contact : BaseModel
    {
        public string Telephone { get; set; }
        public string Email { get; set; }
    }
}
