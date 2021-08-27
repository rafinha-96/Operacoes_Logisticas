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
    public class PropDateTimeStoreHistoryTest
    {
        [Fact]
        public void TestingIfStoreHistoryPropDateExist()
        {
            //Arrange
            Type model = typeof(StoreHistory);
            //Act
            PropertyInfo modelType = model.GetProperties().FirstOrDefault(x => x.Name == "Date");
            //Assert
            Assert.NotNull(modelType);
        }

        [Fact]
        public void TestingIfStoreHistoryPropDateIsDateTime()
        {
            //Arrange
            Type model = typeof(StoreHistory);
            //Act
            PropertyInfo store = model.GetProperties().FirstOrDefault(x => x.Name == "Date");
            Type typeDate = typeof(DateTime);
            Type storeType = store != null ? store.PropertyType : null;
            //Assert
            Assert.Equal(typeDate, storeType);
        }

        [Fact]
        public void TestingStoreHistoryPropDateGetAndSet()
        {
            //Arrange
            StoreHistory model = new StoreHistory();
            Type modelType = typeof(StoreHistory);
            //Act
            PropertyInfo store = modelType.GetProperties().FirstOrDefault(x => x.Name == "Date");
            object valueProp = null;
            if(store != null && store.PropertyType == typeof(DateTime))
            {
                store.SetValue(model, DateTime.Today);
                valueProp = store.GetValue(model);
            }
            //Assert
            Assert.NotNull(valueProp);
        }
    }
}
