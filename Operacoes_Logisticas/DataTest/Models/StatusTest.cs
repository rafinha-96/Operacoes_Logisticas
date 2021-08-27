using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models
{
    public class StatusTest
    {
        [Fact]
        public void TestingInstanceOfClassStatus()
        {
            //arrange
            Status statusTest;
            //act
            statusTest = new Status();
            //assert
            Assert.IsType<Status>(statusTest);
        }
        [Fact]
        public void TestingInheritOfClassStatus()
        {
            //arrange
            bool daughter;
            //act
            Type MotherClass = typeof(BaseModel);
            Type DaughtClass = typeof(Status);
            daughter = DaughtClass.IsSubclassOf(MotherClass);
            //assert
            Assert.True(daughter);
        }
        //test of types
        [Fact]
        public void TestingIdtOfClassStatus()
        {
            //arrange
            Status stt = new Status();
            //act
            var lista = stt.GetType().GetProperties();
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
        public void TestingNametOfClassStatus()
        {
            //arrange
            Status stt = new Status();
            //act
            var lista = stt.GetType().GetProperties();
            foreach (var x in lista)
            {
                if (x.Name == "Name")
                {
                    //assert
                    Assert.Equal("System.String", x.PropertyType.ToString());
                }
            }
        }
        [Fact]
        public void TestingDescriptiontOfClassStatus()
        {
            //arrange
            Status stt = new Status();
            //act
            var lista = stt.GetType().GetProperties();
            foreach (var x in lista)
            {
                if (x.Name == "Description")
                {
                    //assert
                    Assert.Equal("System.String", x.PropertyType.ToString());
                }
            }
        }
        // test of get and set props
        [Fact]
        public void TestingGetSetIdOfClassStatus()
        {
            //arrange
            Status stt = new Status();
            int id;
            //act
            id = 10;
            stt.Id = id;
            //asssert
            Assert.Equal(id, stt.Id);
        }
        [Fact]
        public void TestingGetSetNameOfClassStatus()
        {
            //arrange
            Status stt = new Status();
            string name;
            //act
            name = "testovisk";
            stt.Name = name;
            //asssert
            Assert.Equal(name, stt.Name);
        }
        [Fact]
        public void TestingGetSetDescriptionOfClassStatus()
        {
            //arrange
            Status stt = new Status();
            string desc;
            //act
            desc = "descri";
            stt.Description = desc;
            //asssert
            Assert.Equal(desc, stt.Description);
        }
    }
}
