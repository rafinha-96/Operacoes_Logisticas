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
    public class PropDescriptionClassCategoryTest
    {
        [Fact]
        public void TestPropDescriptionExisist()
        {
            //Arrange
            Type instanceCategory = typeof(Category);
            //Act
            PropertyInfo descriptionInfo = instanceCategory.GetProperties().FirstOrDefault(i => i.Name == "Description");
            //Assert
            Assert.NotNull(descriptionInfo);
        }
        [Fact]
        public void TestPropDescriptionIsString()
        {
            //Arrange
            Type instanceCategory = typeof(Category);
            Type typeString = typeof(string);
            PropertyInfo descriptionInfo = instanceCategory.GetProperties().FirstOrDefault(i => i.Name == "Description");
            //Act
            Type typeCategory = descriptionInfo != null ? descriptionInfo.PropertyType : null;
            //Assert
            Assert.Equal(typeString, typeCategory);
        }
        [Fact]
        public void TestPropDescriptionGet()
        {
            //Arrange
            Type instanceType = typeof(Category);
            Category instanceCategory = Activator.CreateInstance<Category>();
            PropertyInfo descriptionInfo = instanceType.GetProperties().FirstOrDefault(i => i.Name == "Description");
            object valueProp = null;
            //Act
            if (descriptionInfo != null && descriptionInfo.PropertyType == typeof(string))
            {
                descriptionInfo.SetValue(instanceCategory, "");
                valueProp = descriptionInfo.GetValue(instanceCategory);
            }
            //Asserts
            Assert.NotNull(valueProp);
        }
    }
}
