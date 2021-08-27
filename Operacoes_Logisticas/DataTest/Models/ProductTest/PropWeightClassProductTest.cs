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
    public class PropWeightClassProductTest
    {
        [Fact]
        public void TestPropWeightInfoExisist()
        {
            //Arrange
            Type instanceProduct = typeof(Product);
            //Act
            PropertyInfo weightInfo = instanceProduct.GetProperties().FirstOrDefault(i => i.Name == "Weight");
            //Assert
            Assert.NotNull(weightInfo);
        }
        [Fact]
        public void TestPropWeightInfoIsFloat()
        {
            //Arrange
            Type instanceProduct = typeof(Product);
            Type typeFloat = typeof(float);
            PropertyInfo weightInfo = instanceProduct.GetProperties().FirstOrDefault(i => i.Name == "Weight");
            //Act
            Type typeProduct = weightInfo != null ? weightInfo.PropertyType : null;
            //Assert
            Assert.Equal(typeFloat, typeProduct);
        }
        [Fact]
        public void TestPropWeightInfoGet()
        {
            //Arrange
            Type instanceType = typeof(Product);
            Product instanceProduct = Activator.CreateInstance<Product>();
            PropertyInfo weightInfo = instanceType.GetProperties().FirstOrDefault(i => i.Name == "Weight");
            object valueProp = null;
            //Act
            if (weightInfo != null && weightInfo.PropertyType == typeof(float))
            {
                weightInfo.SetValue(instanceProduct, 1.0f);
                valueProp = weightInfo.GetValue(instanceProduct);
            }
            //Asserts
            Assert.NotNull(valueProp);
        }
    }
}
