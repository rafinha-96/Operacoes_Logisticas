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
    public class QuantityPropertyStoreRequestTest
    {
        [Fact]
        public void TestingQuantityPropertyStoreRequestExists()
        {
            //Arrange
            Type t = typeof(StoreRequest);
            //Act
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Quantity");
            //Assert
            Assert.NotNull(pI);
        }

        [Fact]
        public void TestingQuantityPropertyStoreRequestIsInt()
        {
            //Arrange
            Type t = typeof(StoreRequest);
            Type typeString = typeof(int);
            //Act
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Quantity");
            Type typeProperty = pI != null ? pI.PropertyType : null;
            //Assert
            Assert.Equal(typeString, typeProperty);
        }
        [Fact]
        public void TestingQuantityPropertyStoreRequestGet()
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
    }
}
