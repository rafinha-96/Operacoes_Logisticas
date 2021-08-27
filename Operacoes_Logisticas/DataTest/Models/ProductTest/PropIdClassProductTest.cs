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
    public class PropIdClassProductTest
    {
        [Fact]
        public void TestPropIdExisist()
        {
            //Arrange
            Type instanceProduct = typeof(Product);
            //Act
            PropertyInfo idInfo = instanceProduct.GetProperties().FirstOrDefault(i => i.Name == "Id");
            //Assert
            Assert.NotNull(idInfo);
        }
        [Fact]
        public void TestPropIdIsInt()
        {
            //Arrange
            Type instanceProduct = typeof(Product);
            Type typeInt = typeof(int);
            PropertyInfo idInfo = instanceProduct.GetProperties().FirstOrDefault(i => i.Name == "Id");
            //Act
            Type typeProduct = idInfo != null ? idInfo.PropertyType : null;
            //Assert
            Assert.Equal(typeInt, typeProduct);
        }
        [Fact]
        public void TestPropIdGet()
        {
            //Arrange
            Type instanceType = typeof(Product);
            Product instanceProduct = Activator.CreateInstance<Product>();
            PropertyInfo idInfo = instanceType.GetProperties().FirstOrDefault(i => i.Name == "Id");
            object valueProp = null;
            //Act
            if (idInfo != null && idInfo.PropertyType == typeof(int))
            {
                idInfo.SetValue(instanceProduct, 0);
                valueProp = idInfo.GetValue(instanceProduct);
            }
            //Assert
            Assert.NotNull(valueProp);
        }
    }
}
