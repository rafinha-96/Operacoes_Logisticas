using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models.StoreTest
{
    public class StoreTest
    {
        [Fact]
        public void TestingStoreHeritage()
        {
            //assert
            Assert.IsAssignableFrom<BaseModel>(new Store());
        }
        [Fact]
        public void TestingStoreInstance()
        {
            //arrange
            Store storeInstance;
            //act
            storeInstance = Activator.CreateInstance<Store>();
            //assert
            Assert.IsType<Store>(storeInstance);
        }
    }
}
