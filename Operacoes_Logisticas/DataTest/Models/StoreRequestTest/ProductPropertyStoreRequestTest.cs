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
        public void TestingProductPropertyStoreRequestExists()
        {
            //Arrange
            Type t = typeof(StoreRequest);
            //Act
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Product");
            //Assert
            Assert.NotNull(pI);
        }
        [Fact]
        public void TestingProductPropertyStoreRequestComposition()
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
        [Fact]
        public void TestingProductPropertyStoreRequestGet()
        {
            StoreRequest s = new StoreRequest();
            Type t = typeof(StoreRequest);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Product");

            object valueProp = null;
            if (pI != null && pI.PropertyType == typeof(Product))
            {

                pI.SetValue(s, Activator.CreateInstance<Product>());
                valueProp = pI.GetValue(s);
            }

            Assert.NotNull(valueProp);
        }
    }
}
