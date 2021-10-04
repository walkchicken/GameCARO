using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARO_DuongCongNhat
{

    public partial class frmNhat : Form
    {

        #region Properties
        BoardManager Pnl_Board; 
        string PlayerName;
        int sCoreX = 0;
        int sCoreO = 0;
        int gamePlay = 0;
        int gameUndoX = 0;
        int gameUndoO = 0;
        #endregion
        public frmNhat()
        {
            InitializeComponent();

            //tao o co va ve ban co
            Pnl_Board = new BoardManager(pnlBoard, txtPlayer, pbxPlayer);
            Pnl_Board.GameOver += Pnl_Board_GameOver;
            Pnl_Board.PlayerClicked += Pnl_Board_PlayerClicked;

            prcbCountDown.Step = Cons.CountDownStep;
            prcbCountDown.Maximum = Cons.CountDownTime;
            prcbCountDown.Value = 0;

            tmCountDown.Interval = Cons.CountDownInterval;

            NewGame();
           
        }
        #region Methods
        void EndGame()
        {
            tmCountDown.Stop();
            pnlBoard.Enabled = false;
            btn_Undo.Enabled = false;
            //MessageBox.Show("Ket thuc");
        }

        void NewGame()
        {
            prcbCountDown.Value = 0;
            //btn_Undo.Enabled = true;
            btn_Clear.Enabled = true;
            gameUndoX = 0;
            gameUndoO = 0;
            lblUndoX.Text = "0";
            lblUndoO.Text = "0";
            tmCountDown.Stop();

            Pnl_Board.DrawBoard();          
        }

        void Quit()
        {
            Application.Exit();
        }

        void Undo()
        {
            Pnl_Board.Undo();
        }

        private void Pnl_Board_PlayerClicked(object sender, EventArgs e)
        {
            btn_Undo.Enabled = true;
            tmCountDown.Start();
            prcbCountDown.Value = 0;
        }

        private void Pnl_Board_GameOver(object sender, EventArgs e)
        {
            PlayerName = Pnl_Board.ListPlayers[Pnl_Board.CurrentPlayer == 1 ? 0 : 1].Name;
            EndGame();
            MessageBox.Show(PlayerName + " đã chiến thắng ♥ !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(PlayerName == "Người chơi X")
            {
                sCoreX ++;
                gamePlay++;
            }           
            if (PlayerName == "Người chơi O")
            {
                sCoreO++;
                gamePlay++;
            }
            lbl_Score_Mess();
        }


        //thoigian countdown
        private void tmCountDown_Tick(object sender, EventArgs e)
        {
            prcbCountDown.PerformStep(); 

            if(prcbCountDown.Value >= prcbCountDown.Maximum)
            {          
                EndGame();              
                if (txtPlayer.Text == "Người chơi X")
                {
                    MessageBox.Show( "Người chơi X đã thua vì suy nghĩ quá thời gian", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sCoreX++;
                    gamePlay++;
                }
                if (txtPlayer.Text == "Người chơi O")
                {
                    MessageBox.Show("Người chơi O đã thua vì suy nghĩ quá thời gian", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sCoreX++;
                    gamePlay++;
                }
            }
            lbl_Score_Mess();
        }

        private void btn_Newgame_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void btn_Undo_Click(object sender, EventArgs e)
        {
            
            Undo();
            PlayerName = Pnl_Board.ListPlayers[Pnl_Board.CurrentPlayer == 1 ? 0 : 1].Name;
            if (PlayerName == "Người chơi X")
            {
                gameUndoO++;
                
            }
            if (PlayerName == "Người chơi O")
            {
                gameUndoX++;
            }
            lblUndoX.Text = gameUndoX.ToString();
            lblUndoO.Text = gameUndoO.ToString();
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void frmNhat_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát game", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }
        #endregion

        private void lbl_Score_Mess()
        {
            lblWX.Text = sCoreX.ToString();
            lblWO.Text = sCoreO.ToString();
            lblgamePlayX.Text = "/ " + gamePlay.ToString();
            lblgamePlayO.Text = "/ " + gamePlay.ToString();
        }

        private void frmNhat_Load(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa dữ liệu đã chơi", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.Cancel) clear();
            
        }

        private void clear()
        {
            NewGame();
            lblWX.Text = "0";
            lblWO.Text = "0";
            lblgamePlayX.Text = "/ 0";
            lblgamePlayO.Text = "/ 0";
            sCoreX = 0;
            sCoreO = 0;
            gamePlay = 0;
            gameUndoX = 0;
            gameUndoO = 0;
        }

    }
}