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
    public class HelperTests
    {
        [Fact]
        public void When_coordinatesGvien_Perrcentagesreturned_fromHelper()
        {
            //Setup
            var helper = new Helper();

            //Execute
            var result = helper.getCoordinatePercentages(100, 200, 20, 80);

            //Test
            Assert.Equal(50, result.Y);
            Assert.Equal(25, result.X);
            
        }
    }
}
