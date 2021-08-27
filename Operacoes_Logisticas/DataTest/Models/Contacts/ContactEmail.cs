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
    public class StatusName
    {
        [Fact]
        public void TestIfContactEmailExist()
        {
            Type adre = typeof(Contact);
            PropertyInfo prop = adre.GetProperties().FirstOrDefault(t => t.Name == "Email");
            Assert.NotNull(prop);
        }
        [Fact]
        public void TestIfContactEmailIsString()
        {
            Type t = typeof(Contact);
            PropertyInfo prop = t.GetProperties().FirstOrDefault(p => p.Name == "Email");
            Type typestr = typeof(string);
            Type typeProperty = prop != null ? prop.PropertyType : null;
            Assert.Equal(typestr, typeProperty);
        }
        [Fact]
        public void TestGetSePropContactEmail()
        {
            Contact s = new Contact();
            Type t = typeof(Contact);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Email");
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
