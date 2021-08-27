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
    public class StatusPropertyStoreRequestTest
    {
        [Fact]
        public void TestingStatusPropertyStoreRequestExists()
        {
            //Arrange
            Type t = typeof(StoreRequest);
            //Act
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Status");
            //Assert
            Assert.NotNull(pI);
        }
        [Fact]
        public void TestingStatusPropertyStoreRequestComposition()
        {
            //Arrange
            Type t = typeof(StoreRequest);
            Type tstatus = typeof(Status);
            //Act
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Status");
            Type typeProperty = pI != null ? pI.PropertyType : null;
            //Assert
            Assert.Equal(tstatus, typeProperty);
        }
        [Fact]
        public void TestingStatusPropertyStoreRequestGet()
        {
            StoreRequest s = new StoreRequest();
            Type t = typeof(StoreRequest);
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Status");

            object valueProp = null;
            if (pI != null && pI.PropertyType == typeof(Status))
            {

                pI.SetValue(s, Activator.CreateInstance<Status>());
                valueProp = pI.GetValue(s);
            }

            Assert.NotNull(valueProp);
        }
    }
}
