using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models.CategoryTest
{
    public class PropIdClassCategoryTest
    {
        [Fact]
        public void TestPropIdExisist()
        {
            //Arrange
            Type instanceCategory = typeof(Category);
            //Act
            PropertyInfo idInfo = instanceCategory.GetProperties().FirstOrDefault(i => i.Name == "Id");
            //Assert
            Assert.NotNull(idInfo);
        }
        [Fact]
        public void TestPropIdIsInt()
        {
            //Arrange
            Type instanceCategory = typeof(Category);
            Type typeString = typeof(int);
            PropertyInfo idInfo = instanceCategory.GetProperties().FirstOrDefault(i => i.Name == "Id");
            //Act
            Type typeCategory = idInfo != null ? idInfo.PropertyType : null;
            //Assert
            Assert.Equal(typeString, typeCategory);
        }
        [Fact]
        public void TestPropIdGet()
        {
            //Arrange
            Type instanceType = typeof(Category);
            Category instanceCategory = Activator.CreateInstance<Category>();
            PropertyInfo idInfo = instanceType.GetProperties().FirstOrDefault(i => i.Name == "Id");
            object valueProp = null;
            //Act
            if (idInfo != null && idInfo.PropertyType == typeof(int))
            {
                idInfo.SetValue(instanceCategory, 0);
                valueProp = idInfo.GetValue(instanceCategory);
            }
            //Asserts
            Assert.NotNull(valueProp);
        }
    }
}
