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
        private Rectangle Coordinates;
        public int actionType;
        public string chosenAction;
        private ComboBoxItemAccessLayer comboBoxItemAccessLayer;
        private Game _game;

        //Consutructor
        public Pitch()
        {
            InitializeComponent();

            //Set object Variables
            comboBoxItemAccessLayer = new ComboBoxItemAccessLayer();
            _game = new Game();

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

            Coordinates.X = e.X;
            Coordinates.Y = e.Y;

            //if coordinates are inside the 15m and 5m lines then scrum -- TODO use percentages of picturebox and not harcoded coordinates
            if (Coordinates.Y > 125 && Coordinates.Y < 420 && Coordinates.X > 130 && Coordinates.X < 790)
            {
                actionType = (int)setPieceType.scrum;
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

        private void Img_Pitch_Click(object sender, EventArgs e)
        {
            
        }
    }
}
