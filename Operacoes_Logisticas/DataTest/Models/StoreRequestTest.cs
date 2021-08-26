using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models
{
    public class StoreRequestTest
    {
        [Fact]
        public void StoreRequestHeritageTest()
        {
                //assert
                Assert.IsAssignableFrom<BaseModel>(new StoreRequest());
        }
        [Fact]
        public void StoreRequestPropertiesTest()
        {
            //arrange
            StoreRequest storerequest = new StoreRequest();
            int quantitytest = 10;
            //act          
            storerequest.Quantity = quantitytest;
            //assert
            Assert.Equal(quantitytest, storerequest.Quantity);
            Assert.IsType<int>(storerequest.Quantity);
        }
        [Fact]
        public void StoreRequestCompositionTest()
        {
            //arrange
            StoreRequest storerequest;
            storerequest = new StoreRequest();
            Store store = new Store();
            //act
            storerequest.Store = store;
            //assert
            Assert.IsType<Store>(storerequest.Store);

        }
    }
}
