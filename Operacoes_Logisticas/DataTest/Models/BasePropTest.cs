using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models
{
    public class BasePropTest
    {
        private string _nameProp;
        private Type _typeProp { get; set; }
        private Type _ClassType { get; set; }
        public BasePropTest(string nameProp, Type typeProp, Type classType)
        {
            _nameProp = nameProp;
            _typeProp = typeProp;
            _ClassType = classType;
            TestPropExist();
            TestTypeProp();
            TestGetSetProp();
        }
        public void TestPropExist()
        {
            Type t = _ClassType;
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == _nameProp);
            Assert.NotNull(pI);
        }
        public void TestTypeProp()
        {
            Type t = _ClassType;
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == _nameProp);
            Assert.Equal(_typeProp,pI != null ? pI.PropertyType : null);
        }
        public void TestGetSetProp()
        {
            var s = Activator.CreateInstance(_ClassType);
            Type t = _typeProp;
            PropertyInfo pI = s.GetType().GetProperties().FirstOrDefault(p => p.Name == _nameProp);

            object valueProp = null;
            if (pI != null && pI.PropertyType == t)
            {
                if (t == typeof(string)) 
                { 
                    pI.SetValue(s, ""); 
                }else 
                { 
                    pI.SetValue(s, Activator.CreateInstance(_typeProp)); 
                }
                valueProp = pI.GetValue(s);
            }

            Assert.NotNull(valueProp);
        }
    }
}
