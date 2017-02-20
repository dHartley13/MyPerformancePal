namespace MyPerformacePal
{
    partial class Profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbx_firstname = new System.Windows.Forms.TextBox();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.txtbx_Surname = new System.Windows.Forms.TextBox();
            this.teamnameLabel = new System.Windows.Forms.Label();
            this.txtbx_teamname = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.txtbx_password = new System.Windows.Forms.TextBox();
            this.btn_saveandContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbx_firstname
            // 
            this.txtbx_firstname.Location = new System.Drawing.Point(92, 44);
            this.txtbx_firstname.Name = "txtbx_firstname";
            this.txtbx_firstname.Size = new System.Drawing.Size(100, 20);
            this.txtbx_firstname.TabIndex = 0;
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Location = new System.Drawing.Point(13, 47);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstnameLabel.TabIndex = 1;
            this.firstnameLabel.Text = "First Name";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(12, 82);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(49, 13);
            this.surnameLabel.TabIndex = 2;
            this.surnameLabel.Text = "Surname";
            // 
            // txtbx_Surname
            // 
            this.txtbx_Surname.Location = new System.Drawing.Point(92, 82);
            this.txtbx_Surname.Name = "txtbx_Surname";
            this.txtbx_Surname.Size = new System.Drawing.Size(100, 20);
            this.txtbx_Surname.TabIndex = 3;
            // 
            // teamnameLabel
            // 
            this.teamnameLabel.AutoSize = true;
            this.teamnameLabel.Location = new System.Drawing.Point(13, 122);
            this.teamnameLabel.Name = "teamnameLabel";
            this.teamnameLabel.Size = new System.Drawing.Size(65, 13);
            this.teamnameLabel.TabIndex = 4;
            this.teamnameLabel.Text = "Team Name";
            // 
            // txtbx_teamname
            // 
            this.txtbx_teamname.Location = new System.Drawing.Point(92, 121);
            this.txtbx_teamname.Name = "txtbx_teamname";
            this.txtbx_teamname.Size = new System.Drawing.Size(100, 20);
            this.txtbx_teamname.TabIndex = 5;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(12, 163);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password";
            // 
            // txtbx_password
            // 
            this.txtbx_password.Location = new System.Drawing.Point(92, 160);
            this.txtbx_password.Name = "txtbx_password";
            this.txtbx_password.Size = new System.Drawing.Size(100, 20);
            this.txtbx_password.TabIndex = 7;
            // 
            // btn_saveandContinue
            // 
            this.btn_saveandContinue.Location = new System.Drawing.Point(12, 208);
            this.btn_saveandContinue.Name = "btn_saveandContinue";
            this.btn_saveandContinue.Size = new System.Drawing.Size(75, 23);
            this.btn_saveandContinue.TabIndex = 8;
            this.btn_saveandContinue.Text = "Continue";
            this.btn_saveandContinue.UseVisualStyleBackColor = true;
            this.btn_saveandContinue.Click += new System.EventHandler(this.btn_saveandContinue_Click);
            // 
            // Profile
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_saveandContinue);
            this.Controls.Add(this.txtbx_password);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.txtbx_teamname);
            this.Controls.Add(this.teamnameLabel);
            this.Controls.Add(this.txtbx_Surname);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.firstnameLabel);
            this.Controls.Add(this.txtbx_firstname);
            this.Name = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbx_firstname;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox txtbx_Surname;
        private System.Windows.Forms.Label teamnameLabel;
        private System.Windows.Forms.TextBox txtbx_teamname;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox txtbx_password;
        private System.Windows.Forms.Button btn_saveandContinue;
    }
}