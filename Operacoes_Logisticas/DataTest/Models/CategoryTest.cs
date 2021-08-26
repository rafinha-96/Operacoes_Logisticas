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
        public void TestInstanceClassCategory()
        {
            //Arrange
            Category categoryInstance;
            Type compareType = typeof(Category);
            Type typeCategory;
            //Act
            categoryInstance = Activator.CreateInstance<Category>();
            typeCategory = compareType.GetType();
            //Assert
            Assert.Equal(typeCategory, compareType);
        }
    }
}