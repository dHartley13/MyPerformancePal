using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPerformacePal
{
    class ComboBoxItemAccessLayer
    {
        private ComboBoxItemGetter comboBoxItemGetter;

        public ComboBoxItemAccessLayer()
        {
            comboBoxItemGetter = new ComboBoxItemGetter();
        }

        internal List<string> getCategories()
        {
            return comboBoxItemGetter.RetrieveCategories();
        }
    }
}
