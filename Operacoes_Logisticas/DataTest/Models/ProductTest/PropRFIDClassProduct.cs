using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models.ProductTest
{
    public class PropRFIDClassProduct
    {
        [Fact]
        public void TestPropRFIDExisist()
        {
            //Arrange
            Type instanceProduct = typeof(Product);
            //Act
            PropertyInfo rfidInfo = instanceProduct.GetProperties().FirstOrDefault(i => i.Name == "RFID");
            //Assert
            Assert.NotNull(rfidInfo);
        }
        [Fact]
        public void TestPropRFIDIsString()
        {
            //Arrange
            Type instanceProduct = typeof(Product);
            Type typeString = typeof(string);
            PropertyInfo rfidInfo = instanceProduct.GetProperties().FirstOrDefault(i => i.Name == "RFID");
            //Act
            Type typeProduct = rfidInfo != null ? rfidInfo.PropertyType : null;
            //Assert
            Assert.Equal(typeString, typeProduct);
        }
        [Fact]
        public void TestPropRFIDGet()
        {
            //Arrange
            Type instanceType = typeof(Product);
            Product instanceProduct = Activator.CreateInstance<Product>();
            PropertyInfo rfidInfo = instanceType.GetProperties().FirstOrDefault(i => i.Name == "RFID");
            object valueProp = null;
            //Act
            if (rfidInfo != null && rfidInfo.PropertyType == typeof(string))
            {
                rfidInfo.SetValue(instanceProduct, "");
                valueProp = rfidInfo.GetValue(instanceProduct);
            }
            //Asserts
            Assert.NotNull(valueProp);
        }
    }
}
