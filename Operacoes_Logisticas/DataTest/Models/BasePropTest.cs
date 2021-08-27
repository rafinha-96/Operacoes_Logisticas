using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models
{
    public abstract class BasePropTest<T, _typeProp>
    {
        private string _nameProp;
        public BasePropTest(string name)
        {
            _nameProp = name;
        }
        [Fact]
        public void TestPropExist()
        {
            Type t = typeof(T);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == _nameProp);
            Assert.NotNull(pI);
        }
        [Fact]
        public void TestTypeProp()
        {
            Type t = typeof(T);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == _nameProp);
            Assert.Equal(typeof(_typeProp),pI != null ? pI.PropertyType : null);
        }
        [Fact]
        public void TestGetSetProp()
        {
            T s = Activator.CreateInstance<T>();
            Type t = typeof(_typeProp);
            PropertyInfo pI = s.GetType().GetProperties().FirstOrDefault(p => p.Name == _nameProp);

            object valueProp = null;
            if (pI != null && pI.PropertyType == t)
            {
                if (t == typeof(string)) 
                { 
                    pI.SetValue(s, ""); 
                }else 
                { 
                    pI.SetValue(s, Activator.CreateInstance(typeof(_typeProp))); 
                }
                valueProp = pI.GetValue(s);
            }

            Assert.NotNull(valueProp);
        }
    }
}
