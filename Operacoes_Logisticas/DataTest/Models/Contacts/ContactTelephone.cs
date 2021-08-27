using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models.Contacts
{
    public class StatusDescription
    {
        [Fact]
        public void TestIfContactTelephoneExist()
        {
            Type adre = typeof(Contact);
            PropertyInfo prop = adre.GetProperties().FirstOrDefault(t => t.Name == "Telephone");
            Assert.NotNull(prop);
        }
        [Fact]
        public void TestIfContactTelephoneIsString()
        {
            Type t = typeof(Contact);
            PropertyInfo prop = t.GetProperties().FirstOrDefault(p => p.Name == "Telephone");
            Type typestr = typeof(string);
            Type typeProperty = prop != null ? prop.PropertyType : null;
            Assert.Equal(typestr, typeProperty);
        }
        [Fact]
        public void TestGetSePropContactTelephone()
        {
            Contact s = new Contact();
            Type t = typeof(Contact);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Telephone");
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
