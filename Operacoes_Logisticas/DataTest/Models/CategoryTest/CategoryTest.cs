using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models.CategoryTest
{
    public class CategoryTest
    {
        [Fact]
        public void TestInstanceClassCategory()
        {
            //Arrange
            Category categoryInstance;
            Type compareType = typeof(Category);
            Type typeCategory;
            //Act
            categoryInstance = Activator.CreateInstance<Category>();
            typeCategory = categoryInstance.GetType();
            //Assert
            Assert.Equal(compareType, typeCategory);
        }
        [Fact]
        public void TestingHeritageCategory()
        {
            //Arrange
            Category categoryInstance;
            //Act
            categoryInstance = new Category();
            //Assert
            Assert.IsAssignableFrom<BaseModel>(categoryInstance);
        }
    }
}