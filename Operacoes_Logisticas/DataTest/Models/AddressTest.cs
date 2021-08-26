using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models
{
    public class AddressTest
    {
        [Fact]
        public void TestingInstanceAdress()
        {
            Address Ad;
            Ad = new Address();
            Assert.IsType<Address>(Ad);
        }
        [Fact]
        public void TestingInheritsAdressOfBase()
        {
            Type Base = typeof(BaseModel);
            Type Ad = typeof(Address);
            bool IsDaughter = Ad.IsSubclassOf(Base);
            Assert.True(IsDaughter);
        }
        [Fact]
        public void TestingTypePropIdtOfAdress()
        {
            Address ad = new Address();
            int id = 10;
            ad.Id = id;
            Assert.IsType<Int32>(ad.Id);
        }
        [Fact]
        public void TestingTypePropStatetOfAdress()
        {
            Address ad = new Address();
            var lista = ad.GetType().GetProperties();
            foreach (var x in lista)
            {
                if (x.Name == "State")
                {
                    Assert.Equal("System.String", x.PropertyType.ToString());
                }
            }
        }
        [Fact]
        public void TestingTypePropCitytOfAdress()
        {
            Address ad = new Address();
            var lista = ad.GetType().GetProperties();
            foreach (var x in lista)
            {
                if (x.Name == "City")
                {
                    Assert.Equal("System.String", x.PropertyType.ToString());
                }
            }
        }
        [Fact]
        public void TestingTypePropStreettOfAdress()
        {
            Address ad = new Address();
            var lista = ad.GetType().GetProperties();
            foreach (var x in lista)
            {
                if (x.Name == "Street")
                {
                    Assert.Equal("System.String", x.PropertyType.ToString());
                }
            }
        }
        [Fact]
        public void TestingTypePropNumbertOfAdress()
        {
            Address ad = new Address();
            var lista = ad.GetType().GetProperties();
            foreach (var x in lista)
            {
                if (x.Name == "Number")
                {
                    Assert.Equal("System.String", x.PropertyType.ToString());
                }
            }
        }
        [Fact]
        public void TestingTypePropComplementtOfAdress()
        {
            Address ad = new Address();
            var lista = ad.GetType().GetProperties();
            foreach (var x in lista)
            {
                if (x.Name == "Complement")
                {
                    Assert.Equal("System.String", x.PropertyType.ToString());
                }
            }
        }
        [Fact]
        public void TestingTypePropCeptOfAdress()
        {
            Address ad = new Address();
            var lista = ad.GetType().GetProperties();
            foreach (var x in lista)
            {
                if (x.Name == "Cep")
                {
                    Assert.Equal("System.String", x.PropertyType.ToString());
                }
            }
        }
    }
}
