using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models.StoreHistoryTest
{
    public class InstanceStoreHistoryTest
    {
        [Fact]
        public void TestingStoreHistoryInstance()
        {
            //Arrange
            StoreHistory model = new StoreHistory();
            //Assert
            Assert.IsType<StoreHistory>(model);
        }
    }
}
