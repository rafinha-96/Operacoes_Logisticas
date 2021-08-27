using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Xunit;
using Data.Models;

namespace DataTest.Models.StoreTest
{
    public class ProductPropertyStoreTest
    {
            [Fact]
            public void TestingProductPropertyStoreExists()
            {
                //Arrange
                Type t = typeof(Store);
                //Act
                PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Product");
                //Assert
                Assert.NotNull(pI);
            }
            [Fact]
            public void TestingProductPropertyStoreComposition()
            {
                //Arrange
                Type t = typeof(Store);
                Type tproduct = typeof(Product);
                //Act
                PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Product");
                Type typeProperty = pI != null ? pI.PropertyType : null;
                //Assert
                Assert.Equal(tproduct, typeProperty);
            }
    }
}
