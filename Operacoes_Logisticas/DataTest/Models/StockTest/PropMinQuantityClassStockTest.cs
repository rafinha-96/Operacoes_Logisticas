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
    public class PropMinQuantityClassStockTest
    {
        [Fact]
        public void TestPropMinQuantityExixst()
        {
            //Arrange
            Type instanceStock = typeof(Stock);
            //Act
            PropertyInfo minQuantityInfo = instanceStock.GetProperties().FirstOrDefault(i => i.Name == "MinQuantity");
            //Assert
            Assert.NotNull(minQuantityInfo);
        }
        [Fact]
        public void TestPropMinQuantityEString()
        {
            //Arrange
            Type instanceStock = typeof(Stock);
            Type typeInt = typeof(int);
            PropertyInfo minQuantityInfo = instanceStock.GetProperties().FirstOrDefault(i => i.Name == "MinQuantity");
            //Act
            Type propType = minQuantityInfo != null ? minQuantityInfo.PropertyType : null;
            //Assert
            Assert.Equal(typeInt, propType);
        }
        [Fact]
        public void TestePropMinQuantityGet()
        {
            //Arrange
            Type instanceType = typeof(Stock);
            Stock instanceStock = Activator.CreateInstance<Stock>();
            PropertyInfo minQuantityInfo = instanceType.GetProperties().FirstOrDefault(i => i.Name == "MinQuantity");
            //Act
            object valueProp = null;
            if (minQuantityInfo != null && minQuantityInfo.PropertyType == typeof(int))
            {
                minQuantityInfo.SetValue(instanceStock,0);
                valueProp = minQuantityInfo.GetValue(instanceStock);
            }
            //Assert
            Assert.NotNull(valueProp);
        }
    }
}
