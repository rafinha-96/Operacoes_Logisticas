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
    public class PropValueClassProductTest
    {
        [Fact]
        public void TestPropValueInfoExisist()
        {
            //Arrange
            Type instanceProduct = typeof(Product);
            //Act
            PropertyInfo valueInfo = instanceProduct.GetProperties().FirstOrDefault(i => i.Name == "Value");
            //Assert
            Assert.NotNull(valueInfo);
        }
        [Fact]
        public void TestPropValueInfoIsDecimal()
        {
            //Arrange
            Type instanceProduct = typeof(Product);
            Type typeDecimal = typeof(decimal);
            PropertyInfo valueInfo = instanceProduct.GetProperties().FirstOrDefault(i => i.Name == "Value");
            //Act
            Type typeProduct = valueInfo != null ? valueInfo.PropertyType : null;
            //Assert
            Assert.Equal(typeDecimal, typeProduct);
        }
        [Fact]
        public void TestPropValueInfoGet()
        {
            //Arrange
            Type instanceType = typeof(Product);
            Product instanceProduct = Activator.CreateInstance<Product>();
            PropertyInfo valueInfo = instanceType.GetProperties().FirstOrDefault(i => i.Name == "Value");
            object valueProp = null;
            //Act
            if (valueInfo != null && valueInfo.PropertyType == typeof(decimal))
            {
                valueInfo.SetValue(instanceProduct, 1.0m);
                valueProp = valueInfo.GetValue(instanceProduct);
            }
            //Asserts
            Assert.NotNull(valueProp);
        }
    }
}
