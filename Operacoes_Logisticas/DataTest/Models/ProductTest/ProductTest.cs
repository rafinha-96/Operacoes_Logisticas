using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models.ProductTest
{
    public class ProductTest
    {
        [Fact]
        public void TestingInstanceClassProduct()
        {
            //Arrange
            Product productInstance = Activator.CreateInstance<Product>();
            Type compareType = typeof(Product);
            Type typeProduct;
            //Act
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
    }
}
