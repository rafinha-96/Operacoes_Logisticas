using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models
{
    public class ProviderRequestTest
    {
        [Fact]
        public void TestInstanceClassProviderRequest()
        {
            ProviderRequest providerRequestInstance;

            providerRequestInstance = Activator.CreateInstance<ProviderRequest>();

            Assert.IsType<ProviderRequest>(providerRequestInstance);
        }
        [Fact]
        public void TestHeritageClassProviderRequest()
        {
            ProviderRequest providerRequestInstance;

            providerRequestInstance = Activator.CreateInstance<ProviderRequest>();

            Assert.IsAssignableFrom<BaseModel>(providerRequestInstance);
        }
        [Fact]
        public void TestPropIdClassProvider()
        {
            ProviderRequest providerRequestInstance = Activator.CreateInstance<ProviderRequest>();
            int idChanged = 1;

            providerRequestInstance.Id = idChanged;

            Assert.Equal(idChanged, providerRequestInstance.Id);
            Assert.IsType<int>(providerRequestInstance.Quantity);
        }
        [Fact]
        public void TestPropQuantityClassProvider()
        {
            ProviderRequest providerRequestInstance = Activator.CreateInstance<ProviderRequest>();
            int quantityChanged = 1;

            providerRequestInstance.Quantity = quantityChanged;

            Assert.Equal(quantityChanged, providerRequestInstance.Quantity);
            Assert.IsType<int>(providerRequestInstance.Quantity);
        }
    }
}