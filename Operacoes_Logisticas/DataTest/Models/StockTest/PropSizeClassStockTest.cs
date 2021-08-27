using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models.StockTest
{
    public class PropSizeClassStockTest
    {
        [Fact]
        public void TestePropSizeExist()
        {
            //Arrange
            Type instacneStock = typeof(Stock);
            //Act
            PropertyInfo sizeInfo = instacneStock.GetProperties().FirstOrDefault(i => i.Name == "Size");
            //Assert
            Assert.NotNull(sizeInfo);
        }
        [Fact]
        public void TestePropSizeEFloat()
        {
            //Arrange
            Type instanceStock = typeof(Stock);
            Type typeFloat = typeof(float);
            PropertyInfo sizeInfo = instanceStock.GetProperties().FirstOrDefault(i => i.Name =="Size");
            //Act
            Type typeProp = sizeInfo != null ? sizeInfo.PropertyType : null;
            //Assert
            Assert.Equal(typeFloat,typeProp);
        }
        [Fact]
        public void TestePropSizeGet()
        {
            //Arrange
            Stock instanceStock = Activator.CreateInstance<Stock>();
            Type typeStock = typeof(Stock); 
             Type typeFloat = typeof(float);
            PropertyInfo sizeInfo = typeStock.GetProperties().FirstOrDefault(i => i.Name == "Size");
            object valueProp = null;
            //Act
            if (sizeInfo != null && sizeInfo.PropertyType == typeof(float))
            {
                sizeInfo.SetValue(instanceStock,1.0f);
                valueProp = sizeInfo.GetValue(instanceStock);
            }
            //Assert
            Assert.NotNull(valueProp);
        }
    }
}
