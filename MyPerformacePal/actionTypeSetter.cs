using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPerformacePal
{
    //Interface
    public interface IfieldLocationFinder
    {
        int mouseDownLocationFinder(double coordinatesX, double coordinatesY);
    }

    class fieldLocationFinder
    {
        //Class Variables
        public int fieldLocationResult; 


        public enum fieldLocation
        {
            inFeild = 1,
            touchline = 2,
            tryZone = 3
        }

        public int mouseDownLocationFinder(double coordinatesX, double coordinatesY)
        {
            //if coordinates are inside the 15m and 5m lines then scrum -- TODO use percentages of picturebox and not harcoded coordinates
            if (coordinatesY > 125 && coordinatesY < 420 && coordinatesX > 130 && coordinatesX < 790)
            {
                fieldLocationResult = (int)fieldLocation.inFeild;
            }
            else
            {
                fieldLocationResult = (int)fieldLocation.touchline;
            }
            /*else 
            {
                do something for try zone
            }
            */
            return fieldLocationResult;
        }
    }
            
}

