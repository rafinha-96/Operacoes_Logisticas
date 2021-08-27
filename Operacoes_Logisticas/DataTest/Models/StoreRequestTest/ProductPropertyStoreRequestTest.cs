using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Xunit;

namespace DataTest.Models.StoreRequestTest
{
    public class ProductPropertyStoreRequestTest
    {
        [Fact]
        public void TestingProductPropertyExists()
        {
            //Arrange
            Type t = typeof(StoreRequest);
            //Act
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Product");
            //Assert
            Assert.NotNull(pI);
        }
        [Fact]
        public void TestingProductPropertyComposition()
        {
            //Arrange
            Type t = typeof(StoreRequest);
            Type tproduct = typeof(Product);
            //Act
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Product");
            Type typeProperty = pI != null ? pI.PropertyType : null;
            //Assert
            Assert.Equal(tproduct, typeProperty);
        }
    }
}
