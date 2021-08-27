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
    public class QuantityPropertyStoreTest
    {
        [Fact]
        public void TestingQuantityPropertyStoreExists()
        {
            Type t = typeof(Store);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Quantity");
            Assert.NotNull(pI);
        }

        [Fact]
        public void TestingQuantityPropertyStoreIsInt()
        {
            Type t = typeof(Store);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Quantity");
            Type typeString = typeof(int);
            Type typeProperty = pI != null ? pI.PropertyType : null;
            Assert.Equal(typeString, typeProperty);
        }
        [Fact]
        public void TestingQuantityPropertyStoreGet()
        {
            Store s = new Store();
            Type t = typeof(Store);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Quantity");

            object valueProp = null;
            if (pI != null && pI.PropertyType == typeof(Int32))
            {
                pI.SetValue(s, 2);
                valueProp = pI.GetValue(s);
            }
            Assert.NotNull(valueProp);
        }
    }
}