using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Xunit;
using Data.Models;

namespace DataTest.Models.StoreTest
{
    public class NamePropertyStoreTest
    {
        [Fact]
        public void TestingNamePropertyStoreExists()
        {
            //Arrange
            Type t = typeof(Store);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Name");
            Assert.NotNull(pI);
        }
        [Fact]
        public void TestingNamePropertyStoreIsString()
        {
            //Arrange
            Type t = typeof(Store);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Name");
            Type typeString = typeof(string);
            Type typeProperty = pI != null ? pI.PropertyType : null;
            Assert.Equal(typeString, typeProperty);
        }
        [Fact]
        public void TestingNamePropertyStoreGet()
        {
            //Arrange
            Store s = new Store();
            Type t = typeof(Store);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Name");

            object valueProp = null;
            if (pI != null && pI.PropertyType == typeof(String))
            {

                pI.SetValue(s, "");
                valueProp = pI.GetValue(s);
            }

            Assert.NotNull(valueProp);
        }
    }
}
