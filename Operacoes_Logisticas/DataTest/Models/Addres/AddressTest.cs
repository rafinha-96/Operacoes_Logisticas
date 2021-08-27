using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models.Addres
{
    public class AddressTest : BaseClassModelTest<Address>
    {
        public string State { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string Cep { get; set; }
        [Fact]
        public void TestInheritOfBaseModel()
        {
            Address adre;
            adre = Activator.CreateInstance<Address>();
            Assert.IsAssignableFrom<BaseModel>(adre);
        }
    }
}
