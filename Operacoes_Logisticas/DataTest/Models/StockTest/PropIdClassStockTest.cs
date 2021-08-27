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
    public class PropIdClassStockTest
    {
        [Fact]
        public void TestPropIdExisist()
        {
            //Arrange
            Type instanceStock = typeof(Stock);
            //Act
            PropertyInfo idInfo = instanceStock.GetProperties().FirstOrDefault(i => i.Name == "Id");
            //Assert
            Assert.NotNull(idInfo);
        }
        [Fact]
        public void TestPropIdIsInt()
        {
            //Arrange
            Type instanceStock = typeof(Stock);
            //Act
            PropertyInfo idInfo = instanceStock.GetProperties().FirstOrDefault(i => i.Name == "Id");
            Type typeInt = typeof(int);
            Type typeStock = idInfo!=null?idInfo.PropertyType:null;
            //Assert
            Assert.Equal(typeInt,typeStock);
        }
        [Fact]
        public void TestPropIdGet()
        {
            //Arrange
            Stock instanceStock = Activator.CreateInstance<Stock>();
            Type instanceType = typeof(Stock);
            //Act
            PropertyInfo idInfo = instanceType.GetProperties().FirstOrDefault(i => i.Name == "Id");
            object valueProp = null;
            if (idInfo != null && idInfo.PropertyType == typeof(int))
            {
                idInfo.SetValue(instanceStock,0);
                valueProp = idInfo.GetValue(instanceStock);
            }
            //Assert
            Assert.NotNull(valueProp);
        }
    }
}
