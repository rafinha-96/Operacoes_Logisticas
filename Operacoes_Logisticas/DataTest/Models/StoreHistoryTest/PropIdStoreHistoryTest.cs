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
    public class PropIdStoreHistoryTest
    {
        [Fact]
        public void TestingIfStoreHistoryPropIdExist()
        {
            //Arrange
            Type model = typeof(StoreHistory);
            //Act
            PropertyInfo modelType = model.GetProperties().FirstOrDefault(x => x.Name == "Id");
            //Assert
            Assert.NotNull(modelType);
        }

        [Fact]
        public void TestingIfStoreHistoryPropIdIsInt()
        {
            //Arrange
            Type model = typeof(StoreHistory);
            //Act
            PropertyInfo store = model.GetProperties().FirstOrDefault(x => x.Name == "Id");
            Type typeInt = typeof(int);
            Type storeType = store != null ? store.PropertyType : null;
            //Assert
            Assert.Equal(typeInt, storeType);
        }

        [Fact]
        public void TestingStoreHistoryPropIdGetAndSet()
        {
            //Arrange
            StoreHistory model = new StoreHistory();
            Type modelType = typeof(StoreHistory);
            //Act
            PropertyInfo store = modelType.GetProperties().FirstOrDefault(x => x.Name == "Id");
            object valueProp = null;
            if(store != null && store.PropertyType == typeof(int))
            {
                store.SetValue(model, 1);
                valueProp = store.GetValue(model);
            }
            //Assert
            Assert.NotNull(valueProp);
        }
    }
}
