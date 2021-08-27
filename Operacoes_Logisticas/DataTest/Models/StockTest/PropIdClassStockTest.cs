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
            Type typeInt = typeof(int);
            PropertyInfo idInfo = instanceStock.GetProperties().FirstOrDefault(i => i.Name == "Id");
            //Act
            Type typeStock = idInfo !=null ? idInfo.PropertyType : null;
            //Assert
            Assert.Equal(typeInt,typeStock);
        }
        [Fact]
        public void TestPropIdGet()
        {
            //Arrange
            Type instanceType = typeof(Stock);
            Stock instanceStock = Activator.CreateInstance<Stock>();
            PropertyInfo idInfo = instanceType.GetProperties().FirstOrDefault(i => i.Name == "Id");
            object valueProp = null;
            //Act
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
