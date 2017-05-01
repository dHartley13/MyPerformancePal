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
        public double coordinateX;
        public double coordinateY;
        private ComboBoxItemAccessLayer comboBoxItemAccessLayer;
        private Game _game;
        private fieldLocationFinder _fieldLocationFinder;
        private Rectangle Coordinates;

        //Consutructor
        public Pitch()
        {
            InitializeComponent();

            //Set object Variables
            comboBoxItemAccessLayer = new ComboBoxItemAccessLayer();
            _game = new Game();
            _fieldLocationFinder = new fieldLocationFinder();


            //Set ComboBox datasource
            var categories = comboBoxItemAccessLayer.getCategories();
            cmbo_PresentActionChoices.DisplayMember = " ";      //remove autoselect value on combobox
            cmbo_PresentActionChoices.ValueMember = null;       //remove autoselect value on combobox
            cmbo_PresentActionChoices.DataSource = categories;  
        }

        private void PitchUI_Load(object sender, EventArgs e)
        {

        }

        public enum setPieceType
        {
            scrum = 1,
            lineout = 2
        }

        //Private Functions
        private void Img_Pitch_MouseDown(object sender, MouseEventArgs e)
        {
            cmbo_PresentActionChoices.Visible = true;
            cmbo_PresentActionChoices.DroppedDown = true;

            //set coordinates
            coordinateX = e.X;
            coordinateY = e.Y;

            _fieldLocationFinder.mouseDownLocationFinder(coordinateX, coordinateY);

            if (_fieldLocationFinder.fieldLocationResult == 1)
            {
                actionType = (int)setPieceType.scrum;
            }
            else if (_fieldLocationFinder.fieldLocationResult == 2)
            {
                actionType = (int)setPieceType.lineout;
            }

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
