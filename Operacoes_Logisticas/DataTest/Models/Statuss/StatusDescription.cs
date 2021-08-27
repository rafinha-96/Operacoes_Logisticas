using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models.Statuss
{
    public class StatusDescription
    {
        [Fact]
        public void TestIfStatusDescriptionExist()
        {
            Type adre = typeof(Status);
            PropertyInfo prop = adre.GetProperties().FirstOrDefault(t => t.Name == "Description");
            Assert.NotNull(prop);
        }
        [Fact]
        public void TestIfStatusDescriptionIsString()
        {
            Type t = typeof(Status);
            PropertyInfo prop = t.GetProperties().FirstOrDefault(p => p.Name == "Description");
            Type typestr = typeof(string);
            Type typeProperty = prop != null ? prop.PropertyType : null;
            Assert.Equal(typestr, typeProperty);
        }
        [Fact]
        public void TestGetSePropStatusDescription()
        {
            Status s = new Status();
            Type t = typeof(Status);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Description");
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
