using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace DataTest.Models
{
    public class ContactTest
    {
        [Fact]
        public void TestingInstanceOfClassContact()
        {
            //arrange
            Contact contactTest;
            //act
            contactTest = new Contact();
            //assert
            Assert.IsType<Contact>(contactTest);
        }
        [Fact]
        public void TestingInheritOfClassContact()
        {
            //arrange
            bool daughter;
            //act
            Type MotherClass = typeof(BaseModel);
            Type DaughtClass = typeof(Contact);
            daughter = DaughtClass.IsSubclassOf(MotherClass);
            //assert
            Assert.True(daughter);
        }
        [Fact]
        public void TestingIdtOfClassContact()
        {
            //arrange
            Contact contt = new Contact();

            //act
            var lista = contt.GetType().GetProperties();
            foreach (var x in lista)
            {
                if (x.Name == "Id")
                {
                    //assert
                    Assert.Equal("System.Int32", x.PropertyType.ToString());
                }
            }
        }
        [Fact]
        public void TestingThelephonetOfClassContact()
        {
            //arrange
            Contact contt = new Contact();

            //act
            var lista = contt.GetType().GetProperties();
            foreach (var x in lista)
            {
                if (x.Name == "Telephone")
                {
                    //assert
                    Assert.Equal("System.String", x.PropertyType.ToString());
                }
            }
        }
        [Fact]
        public void TestingEmailtOfClassContact()
        {
            //arrange
            Contact contt = new Contact();
            //act
            var lista = contt.GetType().GetProperties();
            foreach (var x in lista)
            {
                if (x.Name == "Email")
                {
                    //assert
                    Assert.Equal("System.String", x.PropertyType.ToString());
                }
            }
        }

    }
}
