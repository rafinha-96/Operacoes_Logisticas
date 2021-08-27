using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models
{
    public abstract class BaseClassModelTest<ClassTest>
    {
        [Fact]
        public void TestInstanceClassProviderRequest()
        {
            ClassTest instance;

            instance = Activator.CreateInstance<ClassTest>();

            Assert.IsType<ClassTest>(instance);
        }
        [Fact]
        public void AllPropTest()
        {           
            foreach (var prop in this.GetType().GetProperties())
            {
                var a =  new BasePropTest(prop.Name,prop.PropertyType,typeof(ClassTest));
            }
        }
    }
}
