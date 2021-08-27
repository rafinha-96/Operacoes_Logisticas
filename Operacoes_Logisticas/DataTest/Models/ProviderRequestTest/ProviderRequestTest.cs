using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models.ProviderRequestTest
{
    public class ProviderRequestTest : BaseClassModelTest<ProviderRequest>
    {
        public int Quantity { get; set; }
        //public Provider Provider { get; set; }
        //public Product Product { get; set; }
        [Fact]
        public void TestHeritageClassProviderRequest()
        {
            ProviderRequest providerRequestInstance;

            providerRequestInstance = Activator.CreateInstance<ProviderRequest>();

            Assert.IsAssignableFrom<BaseModel>(providerRequestInstance);
        }      
    }
}