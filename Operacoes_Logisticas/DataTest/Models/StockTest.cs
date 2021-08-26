using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models
{
    public class StockTest
    {
        [Fact]
        public void TesteInstanciaClasseStock()
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
        [Fact]
        public void TestingIdClassStock()
        {
            //Arrange
            Stock instanceStock;
            int idSetado = 10;
            //Act
            instanceStock = new Stock();
            instanceStock.Id = idSetado;
            //Assert
            Assert.Equal(idSetado,instanceStock.Id);
            Assert.IsType<int>(instanceStock.Id);
        }
        [Fact]
        public void TestingQuantityClassStock()
        {
            //Arrange
            Stock instanceStock;
            int QuantitySetado = 10;
            //Act
            instanceStock = new Stock();
            instanceStock.Quantity = QuantitySetado;
            //Assert
            Assert.Equal(QuantitySetado, instanceStock.Quantity);
            Assert.IsType<int>(instanceStock.Quantity);
        }
        [Fact]
        public void TestingMinQuantityClassStock()
        {
            //Arrange
            Stock instanceStock;
            int MinQuantitySetado = 10;
            //Act
            instanceStock = new Stock();
            instanceStock.MinQuantity = MinQuantitySetado;
            //Assert
            Assert.Equal(MinQuantitySetado, instanceStock.MinQuantity);
            Assert.IsType<int>(instanceStock.MinQuantity);
        }
        [Fact]
        public void TestingMaxQuantityClassStock()
        {
            //Arrange
            Stock instanceStock;
            int MaxQuantitySetado = 10;
            //Act
            instanceStock = new Stock();
            instanceStock.MaxQuantity = MaxQuantitySetado;
            //Assert
            Assert.Equal(MaxQuantitySetado, instanceStock.MaxQuantity);
            Assert.IsType<int>(instanceStock.MaxQuantity);
        }
        [Fact]
        public void TestingSizeClassStock()
        {
            //Arrange
            Stock instanceStock;
            float SizeSetado = 10f;
            //Act
            instanceStock = new Stock();
            instanceStock.Size = SizeSetado;
            //Assert
            Assert.Equal(SizeSetado, instanceStock.Size);
            Assert.IsType<float>(instanceStock.Size);
        }
    }
}
