using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTest.Models.ProviderTest
{
    public class PropIdClassProviderTest : BasePropTest<Provider, int>
    {
        public PropIdClassProviderTest() : base("Id")
        {

        }
    }
}
