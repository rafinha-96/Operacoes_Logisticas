
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models.Addres
{
    public class AddressClass
    {
        [Fact]
        public void TestingInstanceAdress()
        {
            Address Ad;
            Ad = new Address();
            Assert.IsType<Address>(Ad);
        }
        [Fact]
        public void TestingInheritsAdressOfBase()
        {
            Type Base = typeof(BaseModel);
            Type Ad = typeof(Address);
            bool IsDaughter = Ad.IsSubclassOf(Base);
            Assert.True(IsDaughter);
        }
    }
}
