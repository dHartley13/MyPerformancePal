using System.Windows.Input;


namespace MyPerformacePal
{
    partial class Pitch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pitch));
            this.Img_Pitch = new System.Windows.Forms.PictureBox();
            this.cmbo_PresentActionChoices = new System.Windows.Forms.ComboBox();
            this.btn_startgame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Pitch)).BeginInit();
            this.SuspendLayout();
            // 
            // Img_Pitch
            // 
            this.Img_Pitch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Img_Pitch.BackgroundImage")));
            this.Img_Pitch.Location = new System.Drawing.Point(13, 13);
            this.Img_Pitch.Name = "Img_Pitch";
            this.Img_Pitch.Size = new System.Drawing.Size(917, 546);
            this.Img_Pitch.TabIndex = 0;
            this.Img_Pitch.TabStop = false;
            this.Img_Pitch.Click += new System.EventHandler(this.Img_Pitch_Click);
            this.Img_Pitch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Img_Pitch_MouseDown);
            // 
            // cmbo_PresentActionChoices
            // 
            this.cmbo_PresentActionChoices.FormattingEnabled = true;
            this.cmbo_PresentActionChoices.Location = new System.Drawing.Point(936, 13);
            this.cmbo_PresentActionChoices.Name = "cmbo_PresentActionChoices";
            this.cmbo_PresentActionChoices.Size = new System.Drawing.Size(178, 21);
            this.cmbo_PresentActionChoices.TabIndex = 1;
            this.cmbo_PresentActionChoices.SelectedIndexChanged += new System.EventHandler(this.cmbo_PresentActionChoices_SelectedIndexChanged);
            // 
            // btn_startgame
            // 
            this.btn_startgame.Location = new System.Drawing.Point(937, 491);
            this.btn_startgame.Name = "btn_startgame";
            this.btn_startgame.Size = new System.Drawing.Size(177, 68);
            this.btn_startgame.TabIndex = 2;
            this.btn_startgame.Text = "Start Game";
            this.btn_startgame.UseVisualStyleBackColor = true;
            this.btn_startgame.Click += new System.EventHandler(this.btn_startgame_Click);
            // 
            // Pitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 573);
            this.Controls.Add(this.btn_startgame);
            this.Controls.Add(this.cmbo_PresentActionChoices);
            this.Controls.Add(this.Img_Pitch);
            this.Name = "Pitch";
            this.Text = "Pitch";
            this.Load += new System.EventHandler(this.PitchUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Img_Pitch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Img_Pitch;
        private System.Windows.Forms.ComboBox cmbo_PresentActionChoices;
        private System.Windows.Forms.Button btn_startgame;
    }
}

