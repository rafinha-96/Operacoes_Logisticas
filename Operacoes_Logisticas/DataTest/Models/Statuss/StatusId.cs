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
    public class StatusId
    {
        [Fact]
        public void TestIfStatusIdExist()
        {
            Type adre = typeof(Status);
            PropertyInfo prop = adre.GetProperties().FirstOrDefault(t => t.Name == "Id");
            Assert.NotNull(prop);
        }
        [Fact]
        public void TestIfStatusIdIsInt()
        {
            Type t = typeof(Status);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Id");
            Type typeInt = typeof(int);
            Type typeProperty = pI != null ? pI.PropertyType : null;
            Assert.Equal(typeInt, typeProperty);
        }
        [Fact]
        public void TestStatusIdSetGet()
        {
            Status s = new Status();
            Type t = typeof(Status);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Id");
            object valueProp = null;
            if (pI != null && pI.PropertyType == typeof(Int32))
            {
                pI.SetValue(s, 0);
                valueProp = pI.GetValue(s);
            }
            Assert.NotNull(valueProp);
        }
    }
}
