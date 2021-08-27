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
    public class QuantityPropertyStoreRequestTest
    {
        [Fact]
        public void TestingQuantityPropertyStoreRequestExists()
        {
            Type t = typeof(StoreRequest);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Quantity");
            Assert.NotNull(pI);
        }

        [Fact]
        public void TestingQuantityPropertyStoreRequestIsInt()
        {
            Type t = typeof(StoreRequest);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Quantity");
            Type typeString = typeof(int);
            Type typeProperty = pI != null ? pI.PropertyType : null;
            Assert.Equal(typeString, typeProperty);
        }
        [Fact]
        public void TestingQuantityPropertyStoreRequestGet()
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
