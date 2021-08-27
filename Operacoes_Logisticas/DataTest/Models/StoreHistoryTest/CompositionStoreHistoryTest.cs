using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models.StoreHistoryTest
{
    public class CompositionStoreHistoryTest
    {
        [Fact]
        public void TestingIfStoreHistoryHasPropStoreRequest()
        {
            //Arrange
            Type model = typeof(StoreHistory);
            //Act
            PropertyInfo modelType = model.GetProperties().FirstOrDefault(x => x.Name == "StoreRequest");
            //Assert
            Assert.NotNull(modelType);
        }

        [Fact]
        public void TestingStoreHisotryPropStoreRequestType()
        {
            //Arrange
            Type storeHistory = typeof(StoreHistory);
            //Act
            PropertyInfo storeRequest = storeHistory.GetProperties().FirstOrDefault(x => x.Name == "StoreRequest");
            Type storeResquestType = typeof(StoreRequest);
            Type storeType = storeRequest != null ? storeRequest.PropertyType : null;
            //Assert
            Assert.Equal(storeType, storeResquestType);
        }
    }
}
