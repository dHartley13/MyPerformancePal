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


            //Hide buttons and comboboxes on load
            cmbo_PresentActionChoices.Visible = false;
            cmbo_PresentsetPieceType.Visible = false;
            userNotification_pickSetPiece.Visible = false;
            userNotification_selectAction.Visible = false;
            btn_submitRecord.Visible = false;
            btn_finishGame.Visible = false; 
        }

        private void PitchUI_Load(object sender, EventArgs e)
        {

        }

        //Private Functions
        private void Img_Pitch_MouseDown(object sender, MouseEventArgs e)
        {
            //reset the set piece and actions once new mouse down event is initiated
            chosenAction = null;
            chosenSetPiece = null;


            //Get Mousedown coordinates
            pitchPercentageLocation = _helper.getCoordinatePercentages(e.Y, Img_Pitch.Height, e.X, Img_Pitch.Width);

            //set combodata source
            var setPieceTypes = _comboBoxItemAccessLayer.getSetPieceTypes(pitchPercentageLocation);
            cmbo_PresentsetPieceType.SelectedIndexChanged -= cmbo_PresentsetPieceType_SelectedIndexChanged; //unregister the event while datasource is being set (to stop it from auto selecting the first item)
            cmbo_PresentsetPieceType.DataSource = setPieceTypes;
            cmbo_PresentsetPieceType.SelectedIndex = -1;
            cmbo_PresentsetPieceType.SelectedIndexChanged += cmbo_PresentsetPieceType_SelectedIndexChanged; //re register event after datasource bound

            //make next combobox visible
            cmbo_PresentsetPieceType.Visible = true;
            userNotification_pickSetPiece.Visible = true;
        }


        private void btn_startgame_Click(object sender, EventArgs e)
        {
            _game.StartGame();

            //Show submit button
            btn_finishGame.Visible = true;
            btn_startgame.Visible = false;
        }


        //Public Functions
        public void cmbo_PresentActionChoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosenAction = cmbo_PresentActionChoices.SelectedItem.ToString();
            btn_submitRecord.Visible = true;
        }

        //Private Functions 
        private void cmbo_PresentsetPieceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosenSetPiece = cmbo_PresentsetPieceType.SelectedItem.ToString();
            cmbo_PresentActionChoices.Visible = true;
            userNotification_selectAction.Visible = true;

            //Set Categories ComboBox datasource
            cmbo_PresentActionChoices.SelectedIndexChanged -= cmbo_PresentActionChoices_SelectedIndexChanged; //unregister the event while i set my datasource (to stop it from auto selecting the first item)
            var categories = _comboBoxItemAccessLayer.getCategories();  
            cmbo_PresentActionChoices.DataSource = categories;
            cmbo_PresentActionChoices.SelectedIndex = -1;
            cmbo_PresentActionChoices.SelectedIndexChanged += cmbo_PresentActionChoices_SelectedIndexChanged; //re register event after datasource bound
        }

        public void btn_submitRecord_Click(object sender, EventArgs e)
        {
            try
            {
                _game.RecordAction(chosenAction, chosenSetPiece, pitchPercentageLocation);
                cmbo_PresentsetPieceType.Text = "";
                cmbo_PresentActionChoices.Text = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error when calling RecordAction:" + ex);
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
