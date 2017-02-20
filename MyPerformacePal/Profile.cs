using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPerformacePal
{
    public partial class Profile : Form
    {
        public string firstname;
        public string surname;
        public string teamname;
        public string password;

        //contructor
        public Profile()
        {
            InitializeComponent();
        }

       
        private void Profile_Load(object sender, EventArgs e)
        {

        }

        //TODO - capture UI inputs and write to a users table
        private void btn_saveandContinue_Click(object sender, EventArgs e)
        {
            firstname = txtbx_firstname.Text.ToString();
            surname = txtbx_firstname.Text.ToString();
            teamname = txtbx_firstname.Text.ToString();
            password = txtbx_firstname.Text.ToString();
        }
    }
}
