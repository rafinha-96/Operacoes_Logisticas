using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models.Statuss
{
    public class StatusTest : BaseClassModelTest<Status>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        [Fact]
        public void TestingInheritsStatusOfBase()
        {
            Status stt;
            stt = Activator.CreateInstance<Status>();
            Assert.IsAssignableFrom<BaseModel>(stt);
        }
    }
}
