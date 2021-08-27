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
    public class PropQuantityClassStockTest
    {
        [Fact]
        public void PropQuantityExixist()
        {
            //Arrange
            Type instanceType = typeof(Stock);
            //Act
            PropertyInfo idInfo = instanceType.GetProperties().FirstOrDefault(i => i.Name == "Quantity");
            //Assert
            Assert.NotNull(idInfo);
        }
        [Fact]
        public void PropQuantityInt()
        {
            //Arrange
            Type instanceType = typeof(Stock);
            //Act
            PropertyInfo idInfo = instanceType.GetProperties().FirstOrDefault(i => i.Name == "Quantity");
            Type typeInt = typeof(int);
            Type typeStock = idInfo!=null?idInfo.PropertyType:null;
            //Assert
            Assert.Equal(typeInt,typeStock);
        }
        [Fact]
        public void PropQuantityGet()
        {
            //Arrange
            Stock instaceStock = Activator.CreateInstance<Stock>();
            Type instanceType = typeof(Stock);
            //Act
            PropertyInfo idInfo = instanceType.GetProperties().FirstOrDefault(i => i.Name == "Quantity");
            object valueProp = null;
            if (idInfo != null && idInfo.PropertyType == typeof(int))
            {
                idInfo.SetValue(instaceStock,0);
                valueProp = idInfo.GetValue(instaceStock);
            }
            //Assert
            Assert.NotNull(valueProp);
        }
    }
}
