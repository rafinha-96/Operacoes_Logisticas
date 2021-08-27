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
    public class PropNameClassCategory
    {
        [Fact]
        public void TestPropNameExisist()
        {
            //Arrange
            Type instanceCategory = typeof(Category);
            //Act
            PropertyInfo nameInfo = instanceCategory.GetProperties().FirstOrDefault(i => i.Name == "Name");
            //Assert
            Assert.NotNull(nameInfo);
        }
        [Fact]
        public void TestProNameIdIsString()
        {
            //Arrange
            Type instanceCategory = typeof(Category);
            Type typeString = typeof(string);
            PropertyInfo nameInfo = instanceCategory.GetProperties().FirstOrDefault(i => i.Name == "Name");
            //Act
            Type typeCategory = nameInfo != null ? nameInfo.PropertyType : null;
            //Assert
            Assert.Equal(typeString, typeCategory);
        }
        [Fact]
        public void TestPropNameGet()
        {
            //Arrange
            Type instanceType = typeof(Category);
            Category instanceCategory = Activator.CreateInstance<Category>();
            PropertyInfo nameInfo = instanceType.GetProperties().FirstOrDefault(i => i.Name == "Name");
            object valueProp = null;
            //Act
            if (nameInfo != null && nameInfo.PropertyType == typeof(string))
            {
                nameInfo.SetValue(instanceCategory, "");
                valueProp = nameInfo.GetValue(instanceCategory);
            }
            //Asserts
            Assert.NotNull(valueProp);
        }
    }
}
