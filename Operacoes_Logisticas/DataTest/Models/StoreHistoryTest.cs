using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models
{
    public class StoreHistoryTest
    {
        [Fact]
        public void TestingStoreHistoryInstance()
        {
            //Arrange
            StoreHistory model;
            //Act
            model = new StoreHistory();
            //Assert
            Assert.IsType<StoreHistory>(model);
        }

        [Fact]
        public void TestingStoreHistoryHeritage()
        {
            //Arrange
            Type baseType = typeof(BaseModel);
            Type storeHistoryType = typeof(StoreHistory);
            //Act
            bool inherits = storeHistoryType.IsSubclassOf(baseType);
            //Assert
            Assert.True(inherits);
        }

        [Fact]
        public void TestingStoreHistoryIdProp()
        {
            //Arrange
            StoreHistory model;
            int id = 1;
            //Act
            model = new StoreHistory();
            model.Id = id;
            //Assert
            Assert.Equal(id, model.Id);
        }
    }
}
