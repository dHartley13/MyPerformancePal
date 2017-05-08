using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPerformacePal
{

    public class ComboBoxItemAccessLayer
    {
        //Use ComboBoxItemGetter interface
        private readonly IComboBoxItemGetter _comboBoxItemGetter;

        public ComboBoxItemAccessLayer(IComboBoxItemGetter db)
        {
            _comboBoxItemGetter = db;
        }

        private ComboBoxItemGetter comboBoxItemGetter;
       
        //Constructor
        public ComboBoxItemAccessLayer()
        {
            comboBoxItemGetter = new ComboBoxItemGetter();
            _comboBoxItemGetter = new ComboBoxItemGetter();
        }

        public List<string> getCategories()
        {
            return comboBoxItemGetter.RetrieveCategories();
        }

        public List<string> getSetPieceTypes(decimal coordinatesX, decimal coordinatesY)
        {
            return comboBoxItemGetter.RetrieveSetPieces(coordinatesX, coordinatesY); 
        }
    }
}
