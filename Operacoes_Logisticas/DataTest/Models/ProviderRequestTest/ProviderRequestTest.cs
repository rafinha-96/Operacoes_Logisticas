using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models.ProviderRequestTest
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
    }
}