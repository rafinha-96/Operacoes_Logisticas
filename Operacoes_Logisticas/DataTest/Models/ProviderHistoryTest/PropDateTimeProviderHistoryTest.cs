using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models.ProviderHistoryTest
{
    public class PropDateTimeProviderHistoryTest
    {
        [Fact]
        public void TestingIfProviderHistoryPropDateExist()
        {
            //Arrange
            Type model = typeof(ProviderHistory);
            //Act
            PropertyInfo modelProp = model.GetProperties().FirstOrDefault(x => x.Name == "Date");
            //Assert
            Assert.NotNull(modelProp);
        }

        [Fact]
        public void TestingIfProviderHistoryPropDateIsDateTime()
        {
            //Arrange
            Type model = typeof(ProviderHistory);
            //Act
            PropertyInfo modelProp = model.GetProperties().FirstOrDefault(x => x.Name == "Date");
            Type dateType = typeof(DateTime);
            Type modelPropType = modelProp != null ? modelProp.PropertyType : null;
            //Assert
            Assert.Equal(dateType, modelPropType);
        }

        [Fact]
        public void TestingProviderHistoryPropDateGetAndSet()
        {
            //Arrange
            ProviderHistory model = new ProviderHistory();
            Type providerType = typeof(ProviderHistory);
            //Act
            PropertyInfo modelProp = providerType.GetProperties().FirstOrDefault(x => x.Name == "Date");
            object valueProp = null;
            if(modelProp != null && modelProp.PropertyType == typeof(DateTime))
            {
                modelProp.SetValue(model, DateTime.Today);
                valueProp = modelProp.GetValue(model);
            }
            //Assert
            Assert.NotNull(valueProp);
        }
    }
}
