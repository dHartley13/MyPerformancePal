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
        public void When_coordinatesGvien_Perrcentagesreturned_fromHelper()
        {
            //Setup
            var helper = new Helper();

            //Execute
            var result = helper.GetPercentage(100, 200, 20, 100);

            //Test
            Assert.Equal(50, result.yPercentage);
            Assert.Equal(20, result.xPercentage);
        }
    }
}
