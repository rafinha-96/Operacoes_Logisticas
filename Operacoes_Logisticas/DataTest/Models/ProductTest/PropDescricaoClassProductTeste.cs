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
    public class PropDescricaoClassProductTeste
    {
        [Fact]
        public void TestPropDescriptionExisist()
        {
            //Arrange
            Type instanceProduct = typeof(Product);
            //Act
            PropertyInfo descriptionInfo = instanceProduct.GetProperties().FirstOrDefault(i => i.Name == "Description");
            //Assert
            Assert.NotNull(descriptionInfo);
        }
        [Fact]
        public void TestPropDescriptionIsString()
        {
            //Arrange
            Type instanceProduct = typeof(Product);
            Type typeString = typeof(string);
            PropertyInfo descriptionInfo = instanceProduct.GetProperties().FirstOrDefault(i => i.Name == "Description");
            //Act
            Type typeProduct = descriptionInfo != null ? descriptionInfo.PropertyType : null;
            //Assert
            Assert.Equal(typeString, typeProduct);
        }
        [Fact]
        public void TestPropDescriptionGet()
        {
            //Arrange
            Type instanceType = typeof(Product);
            Product instanceProduct = Activator.CreateInstance<Product>();
            PropertyInfo descriptionInfo = instanceType.GetProperties().FirstOrDefault(i => i.Name == "Description");
            object valueProp = null;
            //Act
            if (descriptionInfo != null && descriptionInfo.PropertyType == typeof(string))
            {
                descriptionInfo.SetValue(instanceProduct, "");
                valueProp = descriptionInfo.GetValue(instanceProduct);
            }
            //Asserts
            Assert.NotNull(valueProp);
        }
    }
}
