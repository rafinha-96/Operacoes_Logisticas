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
    public class PropNameClassProductTest
    {
        [Fact]
        public void TestPropNameExisist()
        {
            //Arrange
            Type instanceProduct = typeof(Product);
            //Act
            PropertyInfo nameInfo = instanceProduct.GetProperties().FirstOrDefault(i => i.Name == "Name");
            //Assert
            Assert.NotNull(nameInfo);
        }
        [Fact]
        public void TestPropNameIsString()
        {
            //Arrange
            Type instanceProduct = typeof(Product);
            Type typeString = typeof(string);
            PropertyInfo nameInfo = instanceProduct.GetProperties().FirstOrDefault(i => i.Name == "Name");
            //Act
            Type typeProduct = nameInfo != null ? nameInfo.PropertyType : null;
            //Assert
            Assert.Equal(typeString, typeProduct);
        }
        [Fact]
        public void TestPropNameGet()
        {
            //Arrange
            Type instanceType = typeof(Product);
            Product instanceProduct = Activator.CreateInstance<Product>();
            PropertyInfo nameInfo = instanceType.GetProperties().FirstOrDefault(i => i.Name == "Name");
            object valueProp = null;
            //Act
            if (nameInfo != null && nameInfo.PropertyType == typeof(string))
            {
                nameInfo.SetValue(instanceProduct, "");
                valueProp = nameInfo.GetValue(instanceProduct);
            }
            //Assert
            Assert.NotNull(valueProp);
        }
    }
}
