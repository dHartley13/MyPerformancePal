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

            var pitchLocation = new pitchLocation();

            //Calculate mousedown coordinate percentages against image
            pitchLocation.Y = (decimal)coordinatesY / (decimal)imageHeight *100;
            pitchLocation.X = (decimal)coordinatesX / (decimal)imageWidth *100;


            return pitchLocation;
 
        }

        //Private Functions

    }
            
}

