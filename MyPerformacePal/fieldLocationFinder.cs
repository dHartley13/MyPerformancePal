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
        int onMouseDownFindLocation(double coordinatesX, double coordinatesY);
    }

    class fieldLocationFinder
    {
        //Class Variables
        public int fieldLocationResult;
        private ComboBoxItemGetter _ComboBoxItemGetter;

        //Object Variables

        

        //TODO - unsure what to do with these - they are in the db
        public enum fieldLocation
        {
            inField = 1,
            touchline = 2,
            tryZone = 3
        }

        public void onMouseDownFindLocation(double coordinatesX, double coordinatesY)
        {
            //if coordinates are inside the 15m and 5m lines then scrum -- TODO use percentages of picturebox and not harcoded coordinates
            if (coordinatesY > 125 && coordinatesY < 420 && coordinatesX > 130 && coordinatesX < 790)
            {
                fieldLocationResult = (int)fieldLocation.inField;
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

            //call comboboxItemGetter class to populate combo box depending on what the location of the pitch is
            _ComboBoxItemGetter.RetrieveSetPieces(fieldLocationResult);
        }
    }
            
}

