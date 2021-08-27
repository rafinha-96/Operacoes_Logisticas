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
            //Arrenge             
            Stock instanciaStock;
            //Act
            instanciaStock = Activator.CreateInstance<Stock>();
            //Assert
            Assert.IsType<Stock>(instanciaStock);
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
