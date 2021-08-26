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
        // test types props
        [Fact]
        public void TestingTypePropIdOfAdress()
        {
            Address ad = new Address();
            var lista = ad.GetType().GetProperties();
            foreach (var x in lista)
            {
                if (x.Name == "Id")
                {
                    Assert.Equal("System.Int32", x.PropertyType.ToString());
                }
            }
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
        //test get set props
        [Fact]
        public void TestingGetSetPropIdtOfAdress()
        {
            Address ad = new Address();
            int id = 10;
            ad.Id = id;
            Assert.IsType<Int32>(ad.Id);
        }
        [Fact]
        public void TestingGetSetPropStatetOfAdress()
        {
            Address ad = new Address();
            string state = "state";
            ad.State = state;
            Assert.Equal(state ,ad.State);
        }
        [Fact]
        public void TestingGetSetPropCitytOfAdress()
        {
            Address ad = new Address();
            string city = "city";
            ad.City = city;
            Assert.Equal(city, ad.City);
        }
        [Fact]
        public void TestingGetSetPropStreettOfAdress()
        {
            Address ad = new Address();
            string street = "Street";
            ad.Street = street;
            Assert.Equal(street, ad.Street);
        }
        [Fact]
        public void TestingGetSetPropNumberOfAdress()
        {
            Address ad = new Address();
            string number = "number";
            ad.Number = number;
            Assert.Equal(number, ad.Number);
        }
        [Fact]
        public void TestingGetSetPropComplementOfAdress()
        {
            Address ad = new Address();
            string complement = "complement";
            ad.Complement = complement;
            Assert.Equal(complement, ad.Complement);
        }
        [Fact]
        public void TestingGetSetPropCepOfAdress()
        {
            Address ad = new Address();
            string cep = "cep";
            ad.Cep = cep;
            Assert.Equal(cep, ad.Cep);
        }
    }
}
