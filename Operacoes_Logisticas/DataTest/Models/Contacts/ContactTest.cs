using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models.Contacts
{
    public class StatusClass : BaseClassModelTest<Contact>
    {
        public string Telephone { get; set; }
        public string Email { get; set; }
        [Fact]
        public void TestingInheritsContactOfBase()
        {
            Contact contt;
            contt = Activator.CreateInstance<Contact>();
            Assert.IsAssignableFrom<BaseModel>(contt);
        }
    }
}
