using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models
{
    public class ProductTest
    {
        [Fact]
        public void TestingInstanceClassProduct()
        {
            //Arrange
            Product productInstance;
            Type compareType = typeof(Product);
            Type typeProduct;
            //Act
            productInstance = Activator.CreateInstance<Product>();
            typeProduct = productInstance.GetType();
            //Assert
            Assert.Equal(compareType, typeProduct);
        }
        [Fact]
        public void TestingHeritageProduct()
        {
            //Arrange
            Product productInstance;
            //Act
            productInstance = new Product();
            //Assert
            Assert.IsAssignableFrom<BaseModel>(productInstance);
        }
        [Fact]
        public void TestingIdClassProduct()
        {
            //Arrange
            Product productInstance = new Product();
            int idSeted = 10;
            //Act
            productInstance.Id = idSeted;
            //Assert
            Assert.Equal(idSeted, productInstance.Id);
            Assert.IsType<int>(productInstance.Id);
        }
        [Fact]
        public void TestingNomeClassProduct()
        {
            //Arrange
            Product productInstance = new Product();
            string NameSeted = "Produto";
            //Act
            productInstance.Name = NameSeted;
            //Assert
            Assert.Equal(NameSeted, productInstance.Name);
            Assert.IsType<string>(productInstance.Name);
        }
        [Fact]
        public void TestingDescriptionClassProduct()
        {
            //Arrange
            Product productInstance = new Product();
            string DescritptionSeted = "Descricao";
            //Act
            productInstance.Description = DescritptionSeted;
            //Assert
            Assert.Equal(DescritptionSeted, productInstance.Description);
            Assert.IsType<string>(productInstance.Description);
        }
        [Fact]
        public void TestingWeightClassProduct()
        {
            //Arrange
            Product productInstance = new Product();
            float WeightSeted = 10.1f;
            //Act
            productInstance.Weight = WeightSeted;
            //Assert
            Assert.Equal(WeightSeted, productInstance.Weight);
            Assert.IsType<float>(productInstance.Weight);
        }
        [Fact]
        public void TestingSizeClassProduct()
        {
            //Arrange
            Product productInstance = new Product();
            float SizeSeted = 10.0f;
            //Act
            productInstance.Size = SizeSeted;
            //Assert
            Assert.Equal(SizeSeted, productInstance.Size);
            Assert.IsType<float>(productInstance.Size);
        }
        [Fact]
        public void TestingValueClassProduct()
        {
            //Arrange
            Product productInstance = new Product();
            decimal ValueSeted = 10.00m;
            //Act
            productInstance.Value = ValueSeted;
            //Assert
            Assert.Equal(ValueSeted, productInstance.Value);
            Assert.IsType<decimal>(productInstance.Value);
        }
        [Fact]
        public void TestingRFIDClassProduct()
        {
            //Arrange
            Product productInstance = new Product();
            string RFIDSeted = "RFID";
            //Act
            productInstance.RFID = RFIDSeted;
            //Assert
            Assert.Equal(RFIDSeted, productInstance.RFID);
            Assert.IsType<string>(productInstance.RFID);
        }
    }
}
