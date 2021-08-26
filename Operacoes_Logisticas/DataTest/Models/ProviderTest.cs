using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models
{
    public class ProviderTest
    {
        [Fact]
        public void TestInstanceClassProvider()
        {
            Provider providerInstance;

            providerInstance = Activator.CreateInstance<Provider>();

            Assert.IsType<Provider>(providerInstance);
        }
        [Fact]
        public void TestHeritageClassProvider()
        {
            Provider providerInstance;

            providerInstance = Activator.CreateInstance<Provider>();

            Assert.IsAssignableFrom<BaseModel>(providerInstance);
        }
        [Fact]
        public void TestPropIdClassProvider()
        {
            Provider providerInstance = Activator.CreateInstance<Provider>();
            int idChanged = 1;

            providerInstance.Id = idChanged;

            Assert.Equal(idChanged, providerInstance.Id);
            Assert.IsType<int>(providerInstance.Id);
        }
        [Fact]
        public void TestPropCnpjClassProvider()
        {
            Provider providerInstance = Activator.CreateInstance<Provider>();
            string cnpjChanged = "79.379.491/0008-50";

            providerInstance.Cnpj = cnpjChanged;

            Assert.Equal(cnpjChanged, providerInstance.Cnpj);
            Assert.IsType<string>(providerInstance.Cnpj);
        }
    }
}
