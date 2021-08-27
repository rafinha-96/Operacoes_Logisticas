using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataTest.Models.ProviderRequestTest
{
    public class PropIdClassProvideRequestTest : BasePropTest<ProviderRequest, int>
    {
        public PropIdClassProvideRequestTest() : base("Id")
        {

        }
    }
}
