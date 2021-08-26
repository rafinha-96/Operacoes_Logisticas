using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models
{
    public class StoreTest
    {
        //arrange
        //act
        //assert

        [Fact]
        public void TestingStoreHeritage()
        {
            //assert
            Assert.IsAssignableFrom<BaseModel>(new Store());
        }

        [Fact]
        public void TestingStoreProperties()
        {
            //arrange
            Store store = new Store();
            int idtest = 10;
            string nametest = "TestStore";
            int quantitytest = 20;
            //act
            store.Id = idtest;
            store.Name = nametest;
            store.Quantity = quantitytest;
            //assert
            Assert.Equal(idtest, store.Id);
            Assert.IsType<int>(store.Id);
            Assert.Equal(nametest, store.Name);
            Assert.IsType<string>(store.Name);
            Assert.Equal(quantitytest, store.Quantity);
            Assert.IsType<int>(store.Quantity);

        }
    }
}
