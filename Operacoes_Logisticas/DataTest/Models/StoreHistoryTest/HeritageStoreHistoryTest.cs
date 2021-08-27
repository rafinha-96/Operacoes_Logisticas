using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models.StoreHistoryTest
{
    public class HeritageStoreHistoryTest
    {
        [Fact]
        public void TestingStoreHistoryHeritage()
        {
            //Arrange
            Type baseType = typeof(BaseModel);
            Type storeType = typeof(StoreHistory);
            //Act
            bool inherit = storeType.IsSubclassOf(baseType);
            //Assert
            Assert.True(inherit);
        }
    }
}
