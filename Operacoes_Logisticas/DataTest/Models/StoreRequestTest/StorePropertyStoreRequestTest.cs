using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Xunit;
using Data.Models;

namespace DataTest.Models.StoreRequestTest
{
    public class StorePropertyStoreRequestTest
    {
        [Fact]
        public void TestingStorePropertyStoreRequestExists()
        {
            //Arrange
            Type t = typeof(StoreRequest);
            //Act
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Store");
            //Assert
            Assert.NotNull(pI);
        }
        [Fact]
        public void TestingStorePropertyStoreRequestComposition()
        {
            //Arrange
            Type t = typeof(StoreRequest);
            Type tstore = typeof(Store);
            //Act
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Store");
            Type typeProperty = pI != null ? pI.PropertyType : null;
            //Assert
            Assert.Equal(tstore, typeProperty);
        }

        [Fact]
        public void TestingStorePropertyStoreRequestGet()
        {
            StoreRequest s = new StoreRequest();
            Type t = typeof(StoreRequest);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Store");

            object valueProp = null;
            if (pI != null && pI.PropertyType == typeof(Store))
            {

                pI.SetValue(s, Activator.CreateInstance<Store>());
                valueProp = pI.GetValue(s);
            }

            Assert.NotNull(valueProp);
        }
    }
}
