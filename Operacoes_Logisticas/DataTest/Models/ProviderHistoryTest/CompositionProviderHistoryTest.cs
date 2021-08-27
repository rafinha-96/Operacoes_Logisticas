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
    public class CompositionProviderHistoryTest
    {
        [Fact]
        public void TestingIfProviderHistoryHasPropProviderRequest()
        {
            //Arrange
            Type model = typeof(ProviderHistory);
            //Act
            PropertyInfo modelProp = model.GetProperties().FirstOrDefault(x => x.Name == "ProviderRequest");
            //Assert
            Assert.NotNull(modelProp);
        }

        [Fact]
        public void TestingProviderHisotryPropProviderRequestType()
        {
            //Arrange
            Type providerHistory = typeof(ProviderHistory);
            //Act
            PropertyInfo providerRequest = providerHistory.GetProperties().FirstOrDefault(x => x.Name == "ProviderRequest");
            Type providerRequestType = providerRequest != null ? providerRequest.PropertyType : null;
            Type providerType = typeof(ProviderRequest);
            //Assert
            Assert.Equal(providerType, providerRequestType);
        }
    }
}
