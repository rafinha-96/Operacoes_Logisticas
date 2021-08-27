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
    public class PropMaxQuantityClassStockTest
    {
        [Fact]
        public void TestePropMaxQuantityExist()
        {
            //Arrange
            Type instaceStock = typeof(Stock);
            //Act
            PropertyInfo maxQuantityInfo = instaceStock.GetProperties().FirstOrDefault(i => i.Name == "MaxQuantity");
            //Assert
            Assert.NotNull(maxQuantityInfo);
        }
        [Fact]
        public void TestePropMaxQuantityEInt()
        {
            //Arrange
            Type typeInt = typeof(int);
            Type instaceStock = typeof(Stock);
            PropertyInfo maxQuantityInfo = instaceStock.GetProperties().FirstOrDefault(i => i.Name == "MaxQuantity");
            //Act
            Type propType = maxQuantityInfo != null ? maxQuantityInfo.PropertyType : null;
            //Assert
            Assert.Equal(typeInt, propType);
        }
        [Fact]
        public void TestePropMaxQuantityGet()
        {
            //Arrange
            Type instanceType = typeof(Stock);
            Stock instanceStock = Activator.CreateInstance<Stock>();
            PropertyInfo maxQuantityInfo = instanceType.GetProperties().FirstOrDefault(i => i.Name == "MaxQuantity");
            object valueProp = null;
            //Act
            if (maxQuantityInfo != null && maxQuantityInfo.PropertyType == typeof(int))
            {
                maxQuantityInfo.SetValue(instanceStock,0);
                valueProp = maxQuantityInfo.GetValue(instanceStock);
            }
            //Assert
            Assert.NotNull(valueProp);
        }
    }
}
