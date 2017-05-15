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
        object pitchPercentageLocation;

        private ComboBoxItemAccessLayer _comboBoxItemAccessLayer;
        private Game _game;
        private Helper _helper;
        private pitchLocation _pitchLocation;


        //Consutructor
        public Pitch()
        {
            InitializeComponent();


            //Set object Variables
            _comboBoxItemAccessLayer = new ComboBoxItemAccessLayer();
            _game = new Game();
            _helper = new Helper();
            _pitchLocation = new pitchLocation();


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
            pitchPercentageLocation = _helper.getCoordinatePercentages(e.Y, Img_Pitch.Height, e.X, Img_Pitch.Width);

            var setPieces = _comboBoxItemAccessLayer.getSetPieceTypes(_pitchLocation.X, _pitchLocation.Y);
            cmbo_PresentsetPieceType.DisplayMember = " ";      //remove autoselect value on combobox
            cmbo_PresentsetPieceType.ValueMember = null;       //remove autoselect value on combobox
            cmbo_PresentsetPieceType.DataSource = setPieces;

            //drop down set piece combo box
            cmbo_PresentsetPieceType.DroppedDown = true;
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
                _game.RecordAction(chosenAction, chosenSetPiece, _pitchLocation.X, _pitchLocation.Y);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error when calling RecordAction:" + ex);
                MessageBox.Show(ex.ToString());
            }
        }

        //Private Functions 
        private void cmbo_PresentsetPieceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosenSetPiece = cmbo_PresentsetPieceType.SelectedItem.ToString();
            cmbo_PresentActionChoices.Visible = true;
        }
    }
}
