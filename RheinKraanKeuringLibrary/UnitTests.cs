using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RheinKraanKeuringLibrary
{
    public class UnitTests
    {
        [Fact]
        public void CheckTypeInfo()
        {

            //arrange
            Dictionary<int, List<string>> expectedvalue = new Dictionary<int, List<string>>();
            //act
            var actualvalue = StaticModel.lengte6dlist;
            //assert
            Assert.IsType(actualvalue.GetType(), expectedvalue.GetType());

        }

        [Fact]
        public void CheckType2Info()
        {

            //arrange
            Dictionary<int, string> expectedvalue = new Dictionary<int, string>();
            //act
            var actualvalue = StaticModel.imagepath;
            //assert
            Assert.IsType(actualvalue.GetType(), expectedvalue.GetType());

        }
    }
}
