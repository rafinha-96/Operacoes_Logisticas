using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models.ProviderTest
{
    public class ProviderTest : BaseClassModelTest<Provider>
    {
        public string Cnpj { get; set; }
        //public Contact Contact { get; set; }
        //public Adress Adress { get; set; }
        //public Category Category { get; set; }
        [Fact]
        public void TestHeritageClassProvider()
        {
            Provider providerInstance;

            providerInstance = Activator.CreateInstance<Provider>();

            Assert.IsAssignableFrom<BaseModel>(providerInstance);
        }
    }
}
