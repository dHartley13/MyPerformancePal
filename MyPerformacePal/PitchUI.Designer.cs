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
            this.cmbo_PresentsetPieceType = new System.Windows.Forms.ComboBox();
            this.userNotification_pickSetPiece = new System.Windows.Forms.Label();
            this.userNotification_selectAction = new System.Windows.Forms.Label();
            this.btn_submitRecord = new System.Windows.Forms.Button();
            this.btn_finishGame = new System.Windows.Forms.Button();
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
            this.Img_Pitch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Img_Pitch_MouseDown);
            // 
            // cmbo_PresentActionChoices
            // 
            this.cmbo_PresentActionChoices.FormattingEnabled = true;
            this.cmbo_PresentActionChoices.Location = new System.Drawing.Point(936, 211);
            this.cmbo_PresentActionChoices.Name = "cmbo_PresentActionChoices";
            this.cmbo_PresentActionChoices.Size = new System.Drawing.Size(178, 21);
            this.cmbo_PresentActionChoices.TabIndex = 1;
            this.cmbo_PresentActionChoices.SelectedIndexChanged += new System.EventHandler(this.cmbo_PresentActionChoices_SelectedIndexChanged);
            // 
            // btn_startgame
            // 
            this.btn_startgame.Location = new System.Drawing.Point(936, 491);
            this.btn_startgame.Name = "btn_startgame";
            this.btn_startgame.Size = new System.Drawing.Size(87, 68);
            this.btn_startgame.TabIndex = 2;
            this.btn_startgame.Text = "Start Game";
            this.btn_startgame.UseVisualStyleBackColor = true;
            this.btn_startgame.Click += new System.EventHandler(this.btn_startgame_Click);
            // 
            // cmbo_PresentsetPieceType
            // 
            this.cmbo_PresentsetPieceType.FormattingEnabled = true;
            this.cmbo_PresentsetPieceType.Location = new System.Drawing.Point(937, 42);
            this.cmbo_PresentsetPieceType.Name = "cmbo_PresentsetPieceType";
            this.cmbo_PresentsetPieceType.Size = new System.Drawing.Size(178, 21);
            this.cmbo_PresentsetPieceType.TabIndex = 3;
            this.cmbo_PresentsetPieceType.SelectedIndexChanged += new System.EventHandler(this.cmbo_PresentsetPieceType_SelectedIndexChanged);
            // 
            // userNotification_pickSetPiece
            // 
            this.userNotification_pickSetPiece.AutoSize = true;
            this.userNotification_pickSetPiece.Location = new System.Drawing.Point(937, 23);
            this.userNotification_pickSetPiece.Name = "userNotification_pickSetPiece";
            this.userNotification_pickSetPiece.Size = new System.Drawing.Size(86, 13);
            this.userNotification_pickSetPiece.TabIndex = 4;
            this.userNotification_pickSetPiece.Text = "Pick a set piece!";
            // 
            // userNotification_selectAction
            // 
            this.userNotification_selectAction.AutoSize = true;
            this.userNotification_selectAction.Location = new System.Drawing.Point(937, 195);
            this.userNotification_selectAction.Name = "userNotification_selectAction";
            this.userNotification_selectAction.Size = new System.Drawing.Size(117, 13);
            this.userNotification_selectAction.TabIndex = 5;
            this.userNotification_selectAction.Text = "Select what happened!";
            // 
            // btn_submitRecord
            // 
            this.btn_submitRecord.Location = new System.Drawing.Point(936, 349);
            this.btn_submitRecord.Name = "btn_submitRecord";
            this.btn_submitRecord.Size = new System.Drawing.Size(209, 68);
            this.btn_submitRecord.TabIndex = 6;
            this.btn_submitRecord.Text = "Add Stat";
            this.btn_submitRecord.UseVisualStyleBackColor = true;
            this.btn_submitRecord.Click += new System.EventHandler(this.btn_submitRecord_Click);
            // 
            // btn_finishGame
            // 
            this.btn_finishGame.Location = new System.Drawing.Point(1058, 491);
            this.btn_finishGame.Name = "btn_finishGame";
            this.btn_finishGame.Size = new System.Drawing.Size(87, 68);
            this.btn_finishGame.TabIndex = 7;
            this.btn_finishGame.Text = "Finish Game";
            this.btn_finishGame.UseVisualStyleBackColor = true;
            // 
            // Pitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 573);
            this.Controls.Add(this.btn_finishGame);
            this.Controls.Add(this.btn_submitRecord);
            this.Controls.Add(this.userNotification_selectAction);
            this.Controls.Add(this.userNotification_pickSetPiece);
            this.Controls.Add(this.cmbo_PresentsetPieceType);
            this.Controls.Add(this.btn_startgame);
            this.Controls.Add(this.cmbo_PresentActionChoices);
            this.Controls.Add(this.Img_Pitch);
            this.Name = "Pitch";
            this.Text = "Pitch";
            this.Load += new System.EventHandler(this.PitchUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Img_Pitch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Img_Pitch;
        private System.Windows.Forms.ComboBox cmbo_PresentActionChoices;
        private System.Windows.Forms.Button btn_startgame;
        private System.Windows.Forms.ComboBox cmbo_PresentsetPieceType;
        private System.Windows.Forms.Label userNotification_pickSetPiece;
        private System.Windows.Forms.Label userNotification_selectAction;
        private System.Windows.Forms.Button btn_submitRecord;
        private System.Windows.Forms.Button btn_finishGame;
    }
}

