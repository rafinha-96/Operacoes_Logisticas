using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models.Addres
{
    public class AddressStreet
    {
        [Fact]
        public void TestIfAddressStreetExist()
        {
            Type adre = typeof(Address);
            PropertyInfo prop = adre.GetProperties().FirstOrDefault(t => t.Name == "Street");
            Assert.NotNull(prop);
        }
        [Fact]
        public void TestIfAddressStreetIsString()
        {
            Type t = typeof(Address);
            PropertyInfo prop = t.GetProperties().FirstOrDefault(p => p.Name == "Street");
            Type typestr = typeof(string);
            Type typeProperty = prop != null ? prop.PropertyType : null;
            Assert.Equal(typestr, typeProperty);
        }
        [Fact]
        public void TestGetSePropStreet()
        {
            Address s = new Address();
            Type t = typeof(Address);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Street");
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
