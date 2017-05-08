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
        public string chosenSetPiece;
        public int imageWidth;
        public int imageHeight;
        public decimal coordinatesX;
        public decimal coordinatesY;

        private ComboBoxItemAccessLayer _comboBoxItemAccessLayer;
        private Game _game;
        private Helper _helper;
        

        //Consutructor
        public Pitch(IHelper _helper)
        {
            InitializeComponent();

            //Set object Variables
            _comboBoxItemAccessLayer = new ComboBoxItemAccessLayer();
            _game = new Game();
            _helper = new Helper();


            //Set Categories ComboBox datasource
            var categories = _comboBoxItemAccessLayer.getCategories();
            cmbo_PresentActionChoices.DisplayMember = " ";      //remove autoselect value on combobox
            cmbo_PresentActionChoices.ValueMember = null;       //remove autoselect value on combobox
            cmbo_PresentActionChoices.DataSource = categories;
        }

        private void PitchUI_Load(object sender, EventArgs e)
        {

        }

        //Private Functions
        private void Img_Pitch_MouseDown(object sender, MouseEventArgs e)
        {   

            coordinatesX = _helper.getXCoordinatePercentages(e.X, Img_Pitch.Width);
            coordinatesY = _helper.getYCoordinatePercentages(e.Y, Img_Pitch.Height);

            var setPieces = _comboBoxItemAccessLayer.getSetPieceTypes(coordinatesX, coordinatesY);
            cmbo_PresentsetPieceTypes.DisplayMember = " ";      //remove autoselect value on combobox
            cmbo_PresentsetPieceTypes.ValueMember = null;       //remove autoselect value on combobox
            cmbo_PresentsetPieceTypes.DataSource = setPieces;
  
        }


        public void cmbo_PresentsetPieceTypes(object sender, EventArgs e)
        {

            chosenSetPiece = cmbo_PresentsetPieceTypes.SelectedItem.ToString();


            //drop down action choices once set piece selected
            cmbo_PresentActionChoices.Visible = true;
            cmbo_PresentActionChoices.DroppedDown = true;
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
                _game.RecordAction(actionType, chosenAction, chosenSetPiece, coordinatesX, coordinatesY);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error when calling RecordAction:" + ex);
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
