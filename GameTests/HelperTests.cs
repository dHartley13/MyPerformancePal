using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using MyPerformacePal;
using Moq;
using Xunit;
using Xunit.Runner.TdNet;
using System.Threading.Tasks;

namespace GameTests
{
    class HelperTests
    {
        [Fact]
        public void When_coordinatesGvien_XPerrcentagesreturned_fromHelper()
        {
            //Setup
            var helper = new Helper();

            //Execute
            var result = helper.getXCoordinatePercentages(100, 200);

            //Test
            Assert.Equal(50, result);
            
        }
    

        [Fact]
        public void When_coordinatesGvien_YPerrcentagesreturned_fromHelper()
        {
            //Setup
            var helper = new Helper();

            //Execute
            var result = helper.getYCoordinatePercentages(20, 80);

            //Test
            Assert.Equal(40, result);
        }
    }
}
