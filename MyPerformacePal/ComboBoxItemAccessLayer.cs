using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPerformacePal
{


    public class ComboBoxItemAccessLayer
    {
        //class variables 


        //Interfaces
        private readonly IComboBoxItemGetter _comboBoxItemGetter;
        private readonly IHelper _helper;


        //Constructor
        public ComboBoxItemAccessLayer()
        {
            _comboBoxItemGetter = new ComboBoxItemGetter();
            _helper = new Helper();
        }


        //Public functions
        public List<string> getCategories()
        {
            return _comboBoxItemGetter.RetrieveCategories();
        }

        public List<string> getSetPieceTypes(object pitchPercentageLocation)
        {
            return _comboBoxItemGetter.RetrieveSetPieces(pitchPercentageLocation); 
        }

        //Private functions



    }
}
