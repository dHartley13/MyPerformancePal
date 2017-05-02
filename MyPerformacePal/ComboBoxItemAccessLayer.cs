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
        private readonly IComboBoxItemGetter _db;

        public ComboBoxItemAccessLayer(IComboBoxItemGetter db)
        {
            _db = db;
        }

        private ComboBoxItemGetter comboBoxItemGetter;
       
        //Constructor
        public ComboBoxItemAccessLayer()
        {
            comboBoxItemGetter = new ComboBoxItemGetter();
            _db = new ComboBoxItemGetter();
        }

        public List<string> getCategories()
        {
            return comboBoxItemGetter.RetrieveCategories();
        }

        public List<string> getSetPieceTypes(int coordinatesX, int coordinatesY)
        {
            return comboBoxItemGetter.RetrieveSetPieces(coordinatesX, coordinatesY); 
        }
    }
}
