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
    public class QuantityPropertyStoreTest
    {
        [Fact]
        public void TestingQuantityPropertyStoreExists()
        {
            //Arrange
            Type t = typeof(Store);
            //Act
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Quantity");
            //Assert
            Assert.NotNull(pI);
        }
        [Fact]
        public void TestingQuantityPropertyStoreIsInt()
        {
            //Arrange
            Type t = typeof(Store);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Quantity");
            Type typeString = typeof(int);
            //Act
            Type typeProperty = pI != null ? pI.PropertyType : null;
            //Assert
            Assert.Equal(typeString, typeProperty);
        }
        [Fact]
        public void TestingQuantityPropertyStoreGet()
        {
            //Arrange
            Store s = new Store();
            Type t = typeof(Store);
            object valueProp = null;
            //Act
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Quantity");   
            if (pI != null && pI.PropertyType == typeof(Int32))
            {
                pI.SetValue(s, 2);
                valueProp = pI.GetValue(s);
            }
            //Assert
            Assert.NotNull(valueProp);
        }

        [Fact]
        public void TestingProductPropertyStoreRequestGet()
        {
            Store s = new Store();
            Type t = typeof(Store);
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