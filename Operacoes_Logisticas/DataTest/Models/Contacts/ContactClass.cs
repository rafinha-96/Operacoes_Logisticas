using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models.Contacts
{
    public class StatusClass
    {
        [Fact]
        public void TestingInstanceContact()
        {
            Contact Ad;
            Ad = new Contact();
            Assert.IsType<Contact>(Ad);
        }
        [Fact]
        public void TestingInheritsContactOfBase()
        {
            Type Base = typeof(BaseModel);
            Type Ad = typeof(Contact);
            bool IsDaughter = Ad.IsSubclassOf(Base);
            Assert.True(IsDaughter);
        }
    }
}
