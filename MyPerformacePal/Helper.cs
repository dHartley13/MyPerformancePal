using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPerformacePal
{

    public interface IHelper
    {
        TheModel GetPercentage(int coordinatesY, int imageHeight, int coordinatesX, int imageWidth);
    }

    public class Helper : IHelper
    {
        //Object Variables


        //Public functions
        public TheModel GetPercentage(int coordinatesY, int imageHeight, int coordinatesX, int imageWidth)
        {
            var model = new TheModel();
            model.xPercentage = (decimal)coordinatesX / imageWidth * 100;
            model.yPercentage = (decimal)coordinatesY / imageHeight * 100;
            return model;
        }

        //Private Functions

    }
            
}

