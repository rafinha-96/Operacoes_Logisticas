using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models.Statuss
{
    public class StatusClass
    {
        [Fact]
        public void TestingInstanceStatus()
        {
            Status Ad;
            Ad = new Status();
            Assert.IsType<Status>(Ad);
        }
        [Fact]
        public void TestingInheritsStatusOfBase()
        {
            Type Base = typeof(BaseModel);
            Type Ad = typeof(Status);
            bool IsDaughter = Ad.IsSubclassOf(Base);
            Assert.True(IsDaughter);
        }
    }
}
