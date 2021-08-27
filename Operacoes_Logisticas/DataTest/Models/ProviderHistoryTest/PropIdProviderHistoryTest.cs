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
    public class PropIdProviderHistoryTest
    {
        [Fact]
        public void TestingIfProviderHistoryIdPropExist()
        {
            //Arrange
            Type providerHistory = typeof(ProviderHistory);
            //Act
            PropertyInfo provider = providerHistory.GetProperties().FirstOrDefault(x => x.Name == "Id");
            //Assert
            Assert.NotNull(provider);
        }

        [Fact]
        public void TestingIfProviderHistoryPropIdIsInt()
        {
            //Arrange
            Type providerHistory = typeof(ProviderHistory);
            //Act
            PropertyInfo provider = providerHistory.GetProperties().FirstOrDefault(x => x.Name == "Id");
            Type tipoInt = typeof(int);
            Type providerType = provider != null ? provider.PropertyType : null;
            //Assert
            Assert.Equal(tipoInt, providerType);
        }

        [Fact]
        public void TestingProviderHistoryPropIdGetAndSet()
        {
            //Arrange
            ProviderHistory model = new ProviderHistory();
            Type providerHistory = typeof(ProviderHistory);
            //Act
            PropertyInfo provider = providerHistory.GetProperties().FirstOrDefault(x => x.Name == "Id");
            object valueProp = null;
            if(provider != null && provider.PropertyType == typeof(int))
            {
                provider.SetValue(model, 1);
                valueProp = provider.GetValue(model);
            }
            //Assert
            Assert.NotNull(valueProp);
        }
    }
}
