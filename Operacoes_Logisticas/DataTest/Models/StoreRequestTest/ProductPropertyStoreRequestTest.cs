using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Xunit;

namespace DataTest.Models.StoreRequestTest
{
    public class ProductPropertyStoreRequestTest
    {
        //Arrange
        //Act
        //Assert
        [Fact]
        public void TestingStorePropertyExists()
        {
            //Arrange
            Type t = typeof(Store);
            //Act
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Store");
            //Assert
            Assert.NotNull(pI);
        }
        [Fact]
        public void TestingStorePropertyComposition()
        {
            //Arrange
            Type t = typeof(Store);
            Type typestore = typeof(Store);
            //Act
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Store");
            Type typeProperty = pI != null ? pI.PropertyType : null;
            //Assert
            Assert.Equal(typestore, typeProperty);
        }
        [Fact]
        public void TestingPropertyStoreGet()
        {
            //Arrange
            Store store = new Store();
            Type t = typeof(Store);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Store");
            //act
            object valueProp = null;
            if (pI != null && pI.PropertyType == typeof(Store))
            {

                pI.SetValue(store, Activator.CreateInstance<Store>());
                valueProp = pI.GetValue(store);
            }
            //Assert
            Assert.NotNull(valueProp);
        }

    }
}
