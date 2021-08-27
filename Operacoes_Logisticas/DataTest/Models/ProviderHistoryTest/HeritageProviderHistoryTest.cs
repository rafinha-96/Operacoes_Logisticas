using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models.ProviderHistoryTest
{
    public class HeritageProviderHistoryTest
    {
        [Fact]
        public void TestingProviderHistoryHeritage()
        {
            //Arrange
            Type baseType = typeof(BaseModel);
            Type providerType = typeof(ProviderHistory);
            //Act
            bool inherit = providerType.IsSubclassOf(baseType);
            //Assert
            Assert.True(inherit);
        }
    }
}
