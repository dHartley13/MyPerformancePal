using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPerformacePal
{

    public interface IHelper
    {
        pitchLocation getCoordinatePercentages(int coordinatesY, int imageHeight, int coordinatesX, int imageWidth);
    }

    public class Helper : IHelper
    {
        //Object Variables


        //Public functions
        public pitchLocation getCoordinatePercentages(int coordinatesY, int imageHeight, int coordinatesX, int imageWidth)
        {

            var dto = new pitchLocation();
            
            //Calculate mousedown coordinate percentages against image
            dto.Y = (decimal)coordinatesY / imageHeight * 100;
            dto.X = (decimal)coordinatesX / imageWidth * 100;

            return dto;
 
        }

        //Private Functions

    }
            
}

