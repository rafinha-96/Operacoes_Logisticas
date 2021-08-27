using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Xunit;
using Data.Models;

namespace DataTest.Models.StoreTest
{
    public class StatusPropertyStoreTest
    {
        [Fact]
        public void TestingStatusPropertyStoreExists()
        {
            //Arrange
            Type t = typeof(Store);
            //Act
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Status");
            //Assert
            Assert.NotNull(pI);
        }
        [Fact]
        public void TestingStatusPropertyStoreComposition()
        {
            //Arrange
            Type t = typeof(Store);
            Type tstatus = typeof(Status);
            //Act
            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Status");
            Type typeProperty = pI != null ? pI.PropertyType : null;
            //Assert
            Assert.Equal(tstatus, typeProperty);
        }
    }
}
