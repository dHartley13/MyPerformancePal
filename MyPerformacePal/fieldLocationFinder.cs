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
        private int xRegionPercentage;
        private int yRegionPercentage;

        private ComboBoxItemAccessLayer _comboBoxItemAccessLayer;


        //Object Variables


        //Public functiosn
        public void onMouseDownFindLocation(int coordinatesX, int coordinatesY, int imageWidth, int imageHeight)
        {

            //Calculate mousedown coordinate percentages against image
            xRegionPercentage = (coordinatesX / imageWidth) * 100;
            xRegionPercentage = (coordinatesY / imageHeight) * 100;

            //call _comboBoxItemAccessLayer class to populate combo box depending on what the location of the pitch is
            _comboBoxItemAccessLayer.getSetPieceTypes(xRegionPercentage, yRegionPercentage);
        }
    }
            
}

