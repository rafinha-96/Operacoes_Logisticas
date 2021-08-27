using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models
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
        [Fact]
        public void TestingIdCategory()
        {
            //Arrange
            Category instaceCategory = new Category();
            int idSetado = 10;
            //Act
            instaceCategory.Id = idSetado;
            //Assert
            Assert.Equal(idSetado,instaceCategory.Id);
            Assert.IsType<int>(instaceCategory.Id);
        }
        [Fact]
        public void TestingNameCategory()
        {
            //Arrange
            Category instaceCategory = new Category();
            string NameSetado = "Nome";
            //Act
            instaceCategory.Name = NameSetado;
            //Assert
            Assert.Equal(NameSetado, instaceCategory.Name);
            Assert.IsType<string>(instaceCategory.Name);
        }
        [Fact]
        public void TestingDescriptionCategory()
        {
            //Arrange
            Category instaceCategory = new Category();
            string DescriptionSetado = "Description";
            //Act
            instaceCategory.Description = DescriptionSetado;
            //Assert
            Assert.Equal(DescriptionSetado, instaceCategory.Description);
            Assert.IsType<string>(instaceCategory.Description);
        }
    }
}