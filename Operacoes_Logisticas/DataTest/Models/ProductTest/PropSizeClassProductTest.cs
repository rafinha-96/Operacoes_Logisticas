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
    public class PropSizeClassProductTest
    {
        [Fact]
        public void TestPropSizeInfoExisist()
        {
            //Arrange
            Type instanceProduct = typeof(Product);
            //Act
            PropertyInfo sizeInfo = instanceProduct.GetProperties().FirstOrDefault(i => i.Name == "Size");
            //Assert
            Assert.NotNull(sizeInfo);
        }
        [Fact]
        public void TestPropSizeInfoIsFloat()
        {
            //Arrange
            Type instanceProduct = typeof(Product);
            Type typeFloat = typeof(float);
            PropertyInfo sizeInfo = instanceProduct.GetProperties().FirstOrDefault(i => i.Name == "Size");
            //Act
            Type typeProduct = sizeInfo != null ? sizeInfo.PropertyType : null;
            //Assert
            Assert.Equal(typeFloat, typeProduct);
        }
        [Fact]
        public void TestPropSizeInfoGet()
        {
            //Arrange
            Type instanceType = typeof(Product);
            Product instanceProduct = Activator.CreateInstance<Product>();
            PropertyInfo sizeInfo = instanceType.GetProperties().FirstOrDefault(i => i.Name == "Size");
            object valueProp = null;
            //Act
            if (sizeInfo != null && sizeInfo.PropertyType == typeof(float))
            {
                sizeInfo.SetValue(instanceProduct, 1.0f);
                valueProp = sizeInfo.GetValue(instanceProduct);
            }
            //Asserts
            Assert.NotNull(valueProp);
        }
    }
}
