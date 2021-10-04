
namespace CARO_DuongCongNhat
{
    partial class frmNhat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhat));
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.btn_Newgame = new System.Windows.Forms.Button();
            this.btn_Undo = new System.Windows.Forms.Button();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.pbxPlayer = new System.Windows.Forms.PictureBox();
            this.lblbgcheck = new System.Windows.Forms.Label();
            this.tmCountDown = new System.Windows.Forms.Timer(this.components);
            this.prcbCountDown = new System.Windows.Forms.ProgressBar();
            this.txtPlayer = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWX = new System.Windows.Forms.Label();
            this.lblWO = new System.Windows.Forms.Label();
            this.lblgamePlayO = new System.Windows.Forms.Label();
            this.lblgamePlayX = new System.Windows.Forms.Label();
            this.lblUndoO = new System.Windows.Forms.Label();
            this.lblUndoX = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblUndo = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBoard
            // 
            this.pnlBoard.BackColor = System.Drawing.Color.Black;
            this.pnlBoard.Location = new System.Drawing.Point(0, 0);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(781, 781);
            this.pnlBoard.TabIndex = 0;
            // 
            // btn_Newgame
            // 
            this.btn_Newgame.BackColor = System.Drawing.Color.Black;
            this.btn_Newgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Newgame.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Newgame.Location = new System.Drawing.Point(882, 37);
            this.btn_Newgame.Name = "btn_Newgame";
            this.btn_Newgame.Size = new System.Drawing.Size(86, 60);
            this.btn_Newgame.TabIndex = 1;
            this.btn_Newgame.Text = "New Game";
            this.btn_Newgame.UseVisualStyleBackColor = false;
            this.btn_Newgame.Click += new System.EventHandler(this.btn_Newgame_Click);
            // 
            // btn_Undo
            // 
            this.btn_Undo.BackColor = System.Drawing.Color.Black;
            this.btn_Undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Undo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Undo.Location = new System.Drawing.Point(882, 343);
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.Size = new System.Drawing.Size(193, 60);
            this.btn_Undo.TabIndex = 2;
            this.btn_Undo.Text = "Undo";
            this.btn_Undo.UseVisualStyleBackColor = false;
            this.btn_Undo.Click += new System.EventHandler(this.btn_Undo_Click);
            // 
            // btn_Quit
            // 
            this.btn_Quit.BackColor = System.Drawing.Color.Black;
            this.btn_Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Quit.Location = new System.Drawing.Point(988, 37);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(86, 60);
            this.btn_Quit.TabIndex = 3;
            this.btn_Quit.Text = "Quit";
            this.btn_Quit.UseVisualStyleBackColor = false;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // lbl_Time
            // 
            this.lbl_Time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Time.Location = new System.Drawing.Point(883, 443);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(192, 70);
            this.lbl_Time.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(889, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Time CountDown";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(889, 677);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Score";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Score
            // 
            this.lbl_Score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Score.Location = new System.Drawing.Point(882, 675);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(192, 82);
            this.lbl_Score.TabIndex = 9;
            // 
            // pbxPlayer
            // 
            this.pbxPlayer.BackColor = System.Drawing.SystemColors.Window;
            this.pbxPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxPlayer.Location = new System.Drawing.Point(988, 249);
            this.pbxPlayer.Name = "pbxPlayer";
            this.pbxPlayer.Size = new System.Drawing.Size(87, 60);
            this.pbxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPlayer.TabIndex = 11;
            this.pbxPlayer.TabStop = false;
            // 
            // lblbgcheck
            // 
            this.lblbgcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbgcheck.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblbgcheck.Location = new System.Drawing.Point(870, 268);
            this.lblbgcheck.Name = "lblbgcheck";
            this.lblbgcheck.Size = new System.Drawing.Size(86, 27);
            this.lblbgcheck.TabIndex = 12;
            this.lblbgcheck.Text = "Symbol";
            this.lblbgcheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmCountDown
            // 
            this.tmCountDown.Tick += new System.EventHandler(this.tmCountDown_Tick);
            // 
            // prcbCountDown
            // 
            this.prcbCountDown.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prcbCountDown.Location = new System.Drawing.Point(893, 475);
            this.prcbCountDown.Name = "prcbCountDown";
            this.prcbCountDown.Size = new System.Drawing.Size(172, 23);
            this.prcbCountDown.TabIndex = 13;
        
            // 
            // txtPlayer
            // 
            this.txtPlayer.Location = new System.Drawing.Point(988, 208);
            this.txtPlayer.Multiline = true;
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(86, 24);
            this.txtPlayer.TabIndex = 14;
            this.txtPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Black;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Clear.Location = new System.Drawing.Point(936, 112);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(86, 60);
            this.btn_Clear.TabIndex = 15;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(870, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 27);
            this.label1.TabIndex = 16;
            this.label1.Text = "Player";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(889, 704);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Người Chơi X :";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(888, 728);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Người Chơi O :";
            // 
            // lblWX
            // 
            this.lblWX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWX.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWX.Location = new System.Drawing.Point(997, 704);
            this.lblWX.Name = "lblWX";
            this.lblWX.Size = new System.Drawing.Size(34, 15);
            this.lblWX.TabIndex = 19;
            this.lblWX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWO
            // 
            this.lblWO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWO.Location = new System.Drawing.Point(997, 728);
            this.lblWO.Name = "lblWO";
            this.lblWO.Size = new System.Drawing.Size(34, 15);
            this.lblWO.TabIndex = 20;
            this.lblWO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblgamePlayO
            // 
            this.lblgamePlayO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgamePlayO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblgamePlayO.Location = new System.Drawing.Point(1037, 728);
            this.lblgamePlayO.Name = "lblgamePlayO";
            this.lblgamePlayO.Size = new System.Drawing.Size(34, 15);
            this.lblgamePlayO.TabIndex = 22;
            this.lblgamePlayO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblgamePlayX
            // 
            this.lblgamePlayX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgamePlayX.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblgamePlayX.Location = new System.Drawing.Point(1037, 704);
            this.lblgamePlayX.Name = "lblgamePlayX";
            this.lblgamePlayX.Size = new System.Drawing.Size(34, 15);
            this.lblgamePlayX.TabIndex = 21;
            this.lblgamePlayX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUndoO
            // 
            this.lblUndoO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUndoO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUndoO.Location = new System.Drawing.Point(998, 604);
            this.lblUndoO.Name = "lblUndoO";
            this.lblUndoO.Size = new System.Drawing.Size(63, 15);
            this.lblUndoO.TabIndex = 28;
            this.lblUndoO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUndoX
            // 
            this.lblUndoX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUndoX.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUndoX.Location = new System.Drawing.Point(998, 580);
            this.lblUndoX.Name = "lblUndoX";
            this.lblUndoX.Size = new System.Drawing.Size(63, 15);
            this.lblUndoX.TabIndex = 27;
            this.lblUndoX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label10.Location = new System.Drawing.Point(889, 604);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "Người Chơi O :";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label11.Location = new System.Drawing.Point(890, 580);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "Người Chơi X :";
            // 
            // lblUndo
            // 
            this.lblUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUndo.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblUndo.Location = new System.Drawing.Point(890, 553);
            this.lblUndo.Name = "lblUndo";
            this.lblUndo.Size = new System.Drawing.Size(175, 17);
            this.lblUndo.TabIndex = 24;
            this.lblUndo.Text = "Số Lần Undo Trong Ván";
            this.lblUndo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(883, 551);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(192, 82);
            this.label13.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(0, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 806);
            this.label6.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(840, 60);
            this.label7.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(0, 780);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(840, 61);
            this.label8.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(780, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 806);
            this.label9.TabIndex = 32;
            // 
            // frmNhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1117, 841);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblUndoO);
            this.Controls.Add(this.lblUndoX);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblUndo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblgamePlayO);
            this.Controls.Add(this.lblgamePlayX);
            this.Controls.Add(this.lblWO);
            this.Controls.Add(this.lblWX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.txtPlayer);
            this.Controls.Add(this.prcbCountDown);
            this.Controls.Add(this.pbxPlayer);
            this.Controls.Add(this.lblbgcheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.btn_Undo);
            this.Controls.Add(this.btn_Newgame);
            this.Controls.Add(this.pnlBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNhat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game CARO PvsP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNhat_FormClosing);
            this.Load += new System.EventHandler(this.frmNhat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Button btn_Newgame;
        private System.Windows.Forms.Button btn_Undo;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.PictureBox pbxPlayer;
        private System.Windows.Forms.Label lblbgcheck;
        private System.Windows.Forms.Timer tmCountDown;
        private System.Windows.Forms.ProgressBar prcbCountDown;
        private System.Windows.Forms.TextBox txtPlayer;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblWX;
        private System.Windows.Forms.Label lblWO;
        private System.Windows.Forms.Label lblgamePlayO;
        private System.Windows.Forms.Label lblgamePlayX;
        private System.Windows.Forms.Label lblUndoO;
        private System.Windows.Forms.Label lblUndoX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblUndo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

