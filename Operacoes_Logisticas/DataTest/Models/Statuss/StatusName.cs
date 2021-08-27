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
    public class StatusName
    {
        [Fact]
        public void TestIfStatusNameExist()
        {
            Type adre = typeof(Status);
            PropertyInfo prop = adre.GetProperties().FirstOrDefault(t => t.Name == "Name");
            Assert.NotNull(prop);
        }
        [Fact]
        public void TestIfStatusNameIsString()
        {
            Type t = typeof(Status);
            PropertyInfo prop = t.GetProperties().FirstOrDefault(p => p.Name == "Name");
            Type typestr = typeof(string);
            Type typeProperty = prop != null ? prop.PropertyType : null;
            Assert.Equal(typestr, typeProperty);
        }
        [Fact]
        public void TestGetSePropStatusName()
        {
            Status s = new Status();
            Type t = typeof(Status);
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
