using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models.ProviderHistoryTest
{
    public class InstanceProviderHistoryTest
    {
        [Fact]
        public void TestingProviderHistoryInstance()
        {
            //Arrange
            ProviderHistory model = new ProviderHistory();
            //Act

            //Assert
            Assert.IsType<ProviderHistory>(model);
        }
    }
}
