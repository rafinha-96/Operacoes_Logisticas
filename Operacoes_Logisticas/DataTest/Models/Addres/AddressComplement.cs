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
    public class AddressComplement
    {
        [Fact]
        public void TestIfAddressComplementExist()
        {
            Type adre = typeof(Address);
            PropertyInfo prop = adre.GetProperties().FirstOrDefault(t => t.Name == "Complement");
            Assert.NotNull(prop);
        }
        [Fact]
        public void TestIfAddressComplementIsString()
        {
            Type t = typeof(Address);
            PropertyInfo prop = t.GetProperties().FirstOrDefault(p => p.Name == "Complement");
            Type typestr = typeof(string);
            Type typeProperty = prop != null ? prop.PropertyType : null;
            Assert.Equal(typestr, typeProperty);
        }
        [Fact]
        public void TestGetSePropComplement()
        {
            Address s = new Address();
            Type t = typeof(Address);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Complement");
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
