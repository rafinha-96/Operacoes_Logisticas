using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Xunit;
using Data.Models;

namespace DataTest.Models.StoreRequestTest
{
    public class StorePropertyStoreRequestTest
    {
        [Fact]
        public void TestingStorePropertyExists()
        {
            //Arrange
            Type t = typeof(StoreRequest);
            //Act
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Store");
            //Assert
            Assert.NotNull(pI);
        }
        [Fact]
        public void TestingStorePropertyComposition()
        {
            //Arrange
            Type t = typeof(StoreRequest);
            Type tstore = typeof(Store);
            //Act
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Store");
            Type typeProperty = pI != null ? pI.PropertyType : null;
            //Assert
            Assert.Equal(tstore, typeProperty);
        }
    }
}
