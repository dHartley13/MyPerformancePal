﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPerformacePal
{
    //Interface
    public interface IHelper
    {
        decimal getXCoordinatePercentages(int coordinatesX, int imageWidth);
        decimal getYCoordinatePercentages(int coordinatesY, int imageHeight);
    }

    public class Helper : IHelper
    {
        //Object Variables


        //Public functiosn
        public decimal getXCoordinatePercentages(int coordinatesX, int imageWidth)
        {
            //Calculate mousedown coordinate percentages against image
            var xRegionPercentage = (coordinatesX / imageWidth) * 100;

            return xRegionPercentage;
        }

        public decimal getYCoordinatePercentages(int coordinatesY, int imageHeight)
        {
            //Calculate mousedown coordinate percentages against image
            var yRegionPercentage = (coordinatesY / imageHeight) * 100;

            return yRegionPercentage;
        }
    }
            
}

