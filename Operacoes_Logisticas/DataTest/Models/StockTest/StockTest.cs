using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models.StockTest
{
    public class StockTest
    {
        [Fact]
        public void TesteInstanciaClassStock()
        {
            //Arrange
            Stock stockInstance = Activator.CreateInstance<Stock>();
            Type compareType = typeof(Stock);
            Type typeStock;
            //Act
            typeStock = stockInstance.GetType();
            //Assert
            Assert.Equal(compareType, typeStock);
        }
        [Fact]
        public void TestingHeritageClassStock()
        {
            //Arrenge
            Stock instanceStock;
            //Act
            instanceStock = Activator.CreateInstance<Stock>();
            //Assert
            Assert.IsAssignableFrom<Stock>(instanceStock);
        }
    }
}
