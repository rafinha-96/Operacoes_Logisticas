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
        //testing types
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
        // test of get and set props
        [Fact]
        public void TestingGetSetIdOfClassContact()
        {
            //arrange
            Contact contt = new Contact();
            int id;
            //act
            id = 10;
            contt.Id = id;
            //asssert
            Assert.Equal(id, contt.Id);
        }
        [Fact]
        public void TestingGetSetTelephoneOfClassContact()
        {
            //arrange
            Contact contt = new Contact();
            string tel;
            //act
            tel = "047";
            contt.Telephone = tel;
            //asssert
            Assert.Equal(tel, contt.Telephone);
        }
        [Fact]
        public void TestingGetSetEmailOfClassContact()
        {
            //arrange
            Contact contt = new Contact();
            string mail;
            //act
            mail = "047";
            contt.Email = mail;
            //asssert
            Assert.Equal(mail, contt.Email);
        }
    }
}
