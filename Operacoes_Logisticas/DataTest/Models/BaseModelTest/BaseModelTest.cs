using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models
{
    public class BaseModelTest
    {
        [Fact]
        public void TestAbstractClassBaseModel()
        {
            Action activatorBaseInstance = () => Activator.CreateInstance<BaseModel>();

            Assert.Throws<MissingMethodException>(activatorBaseInstance);
        }
    }
}
