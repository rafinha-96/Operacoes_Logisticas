using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models
{
    public class ProviderHistoryTeste
    {
        [Fact]
        public void TestingProviderHistoryInstance()
        {
            //Arrange
            ProviderHistory model;
            //Act
            model = new ProviderHistory();
            //Assert
            Assert.IsType<ProviderHistory>(model);
        }

        [Fact]
        public void TestingProviderHistoryHeritage()
        {
            //Arrange
            Type baseModelType = typeof(BaseModel);
            Type providerHistoryType = typeof(ProviderHistory);
            //Act
            bool inherits = providerHistoryType.IsSubclassOf(baseModelType);
            //Assert
            Assert.True(inherits);
        }

        [Fact]
        public void TestingProviderHistoryIdProp()
        {
            //Arrange
            ProviderHistory model = new ProviderHistory();
            int id = 1;
            //Act
            model.Id = id;
            //Assert
            Assert.IsType<int>(model.Id);
            Assert.Equal(id, model.Id);            
        }

        [Fact]
        public void TestingProviderHistoryDateTimeProp()
        {
            //Arrange
            ProviderHistory model = new ProviderHistory();
            DateTime date = DateTime.Today;
            //Act
            model.Date = date;
            //Assert
            Assert.IsType<DateTime>(model.Date);
            Assert.Equal(date, model.Date);
        }
    }
}
