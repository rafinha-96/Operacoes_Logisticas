using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models.StoreRequestTest
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
        [Fact]

        public void TestingStoreRequestInstance()
        {
            //arrange
            StoreRequest storerequestinstance;
            //act
            storerequestinstance = Activator.CreateInstance<StoreRequest>();
            //assert
            Assert.IsType<StoreRequest>(storerequestinstance);
        }
    }
}
