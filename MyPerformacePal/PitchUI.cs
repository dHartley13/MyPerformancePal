using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace MyPerformacePal
{
    public partial class Pitch : Form
    {
        //Class Variables
        public int actionType;
        public string chosenAction;
        public int imageWidth;
        public int imageHeight;

        private ComboBoxItemAccessLayer _comboBoxItemAccessLayer;
        private Game _game;
        private fieldLocationFinder _fieldLocationFinder;
        

        //Consutructor
        public Pitch()
        {
            InitializeComponent();

            //Set object Variables
            _comboBoxItemAccessLayer = new ComboBoxItemAccessLayer();
            _game = new Game();
            _fieldLocationFinder = new fieldLocationFinder();
            imageWidth = Img_Pitch.Width;
            imageHeight = Img_Pitch.Height;


            //Set ComboBox datasource
            var categories = _comboBoxItemAccessLayer.getCategories();
            cmbo_PresentActionChoices.DisplayMember = " ";      //remove autoselect value on combobox
            cmbo_PresentActionChoices.ValueMember = null;       //remove autoselect value on combobox
            cmbo_PresentActionChoices.DataSource = categories;

            //TODO - add select set piece combo box to UI - I can't call the getSetPieceTypes method from here. I dont know the coordinates
            /*
            var setPieces = _comboBoxItemAccessLayer.getSetPieceTypes();
            cmbo_PresentsetPieceTypes.DisplayMember = " ";      //remove autoselect value on combobox
            cmbo_PresentsetPieceTypes.ValueMember = null;       //remove autoselect value on combobox
            cmbo_PresentsetPieceTypes.DataSource = setPieces;
            */


        }

        private void PitchUI_Load(object sender, EventArgs e)
        {

        }

        //Private Functions
        private void Img_Pitch_MouseDown(object sender, MouseEventArgs e)
        {
            cmbo_PresentActionChoices.Visible = true;
            cmbo_PresentActionChoices.DroppedDown = true;


            _fieldLocationFinder.onMouseDownFindLocation(e.X, e.Y, imageWidth, imageHeight);
        }

        private void btn_startgame_Click(object sender, EventArgs e)
        {
            _game.StartGame();
        }


        //Public Functions
        public void cmbo_PresentActionChoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                chosenAction = cmbo_PresentActionChoices.SelectedItem.ToString();
                _game.RecordAction(actionType, chosenAction);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error when calling RecordAction:" + ex);
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
