using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARO_DuongCongNhat
{
    public class BoardManager
    {
        #region Properties
        private Panel board; 

        private int currentPlayer;
        private TextBox playerName;
        private PictureBox avatar;

        private List<Player> listPlayers;
        private List<List<Button>> matrixPositions;
        private event EventHandler<BtnClickEvent> playerClicked;
        private event EventHandler gameOver;

        private Stack<PlayInfo> stkUndoStep;
        private Stack<PlayInfo> stkRedoStep;

        private int playMode = 0;

        public Panel Board
        {
            get { return board; }
            set { board = value; }
        }
                  
        public int CurrentPlayer
        {
            get { return currentPlayer; }
            set { currentPlayer = value; }
        }

        public TextBox PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        public PictureBox Avatar
        {
            get { return avatar; }
            set { avatar = value; }
        }

        public List<Player> ListPlayers
        {
            get { return listPlayers; }
            set { listPlayers = value; }
        }

        public List<List<Button>> MatrixPositions
        {
            get { return matrixPositions; }
            set { matrixPositions = value; }
        }


        public event EventHandler GameOver
        {
            add { gameOver += value; }
            remove { gameOver -= value; }
        }

        public int PlayMode
        {
            get { return playMode; }
            set { playMode = value; }
        }

        internal Stack<PlayInfo> StkUndoStep { get => stkUndoStep; set => stkUndoStep = value; }
        internal Stack<PlayInfo> StkRedoStep { get => stkRedoStep; set => stkRedoStep = value; }
        public event EventHandler<BtnClickEvent> PlayerClicked 
        {
            add { playerClicked += value; }
            remove { playerClicked -= value; }
        }
        #endregion

        #region Initialize
        // taoj ham dung
        public BoardManager(Panel board, TextBox PlayerName, PictureBox Avatar)
        {
            this.Board = board;
            this.PlayerName = PlayerName;
            this.Avatar = Avatar;

            this.CurrentPlayer = 0;
            this.ListPlayers = new List<Player>()
            {
                new Player("Người chơi X",Image.FromFile(Application.StartupPath + "\\Resources\\x.png"),Image.FromFile(Application.StartupPath + "\\Resources\\x.png")),
                new Player("Người chơi O",Image.FromFile(Application.StartupPath + "\\Resources\\o.png"),Image.FromFile(Application.StartupPath + "\\Resources\\o.png"))
            };

        }
        #endregion

        #region Methods
        //ham ve button
        public void DrawBoard()
        {
            board.Enabled = true;
            board.Controls.Clear();

            StkUndoStep = new Stack<PlayInfo>();
            StkRedoStep = new Stack<PlayInfo>();

            this.CurrentPlayer = 0;
            ChangePlayer();

            int LocX, LocY;
            int nRowsX = Cons.nRowsX;
            int nColsY = Cons.nColsY;

            Button OldButton = new Button();
            OldButton.Width = OldButton.Height = 0;
            OldButton.Location = new Point(0, 0);

            MatrixPositions = new List<List<Button>>();

            for (int i = 0; i < nRowsX; i++)
            {
                MatrixPositions.Add(new List<Button>());

                for (int j = 0; j < nColsY; j++)
                {
                    LocX = OldButton.Location.X + OldButton.Width;
                    LocY = OldButton.Location.Y;

                    Button btn = new Button()
                    {
                        Width = Cons.CellWidth,
                        Height = Cons.CellHeight,

                        Location = new Point(LocX, LocY),
                        Tag = i.ToString(), // Để xác định button đang ở hàng nào

                        BackColor = Color.White,
                        BackgroundImageLayout = ImageLayout.Stretch
                    };

                    btn.Click += btn_Click;
                    MatrixPositions[i].Add(btn);

                    Board.Controls.Add(btn);
                    OldButton = btn;
                }

                OldButton.Location = new Point(0, OldButton.Location.Y + Cons.CellHeight);
                OldButton.Width = OldButton.Height = 0;
            }
        }
        private Point GetButtonCoordinate(Button btn)
        {
            int Vertical = Convert.ToInt32(btn.Tag);
            int Horizontal = MatrixPositions[Vertical].IndexOf(btn);

            Point Coordinate = new Point(Horizontal, Vertical);
            return Coordinate;
        }

        #region Undo 
        public bool Undo()
        {
            if (StkUndoStep.Count <= 0)
            {
                return false;
            }

            PlayInfo OldPos = StkUndoStep.Pop();
            //StkRedoStep.Push(OldPos);

            Button btn = MatrixPositions[OldPos.Point.Y][OldPos.Point.X];
            btn.BackgroundImage = null;

            if (StkUndoStep.Count <= 0)
            {
                CurrentPlayer = 0;
            }
            else
            {
                OldPos = StkUndoStep.Peek();
                CurrentPlayer = OldPos.CurrentPlayer == 1 ? 0 : 1;
            }
            ChangePlayer();

            return false;
        }

        /*private bool UndoAStep()
        {
            if (StkUndoStep.Count <= 0)
                return false;

            PlayInfo OldPos = StkUndoStep.Pop();
            StkRedoStep.Push(OldPos);

            Button btn = MatrixPositions[OldPos.Point.Y][OldPos.Point.X];
            btn.BackgroundImage = null;

            if (StkUndoStep.Count <= 0)
            {
                CurrentPlayer = 0;
            }
            else
            {
                OldPos = StkUndoStep.Peek();
                CurrentPlayer = OldPos.CurrentPlayer == 1 ? 0 : 1;
            }
            ChangePlayer();

            return true;
        }

        public bool Redo()
        {
            if (StkRedoStep.Count <= 0)
                return false;

            PlayInfo OldPos = StkRedoStep.Peek();
            CurrentPlayer = OldPos.CurrentPlayer;

            bool IsRedo1 = RedoAStep();
            bool IsRedo2 = RedoAStep();

            return IsRedo1 && IsRedo2;
        }

        private bool RedoAStep()
        {
            if (StkRedoStep.Count <= 0)
                return false;

            PlayInfo OldPos = StkRedoStep.Pop();
            StkUndoStep.Push(OldPos);

            Button btn = MatrixPositions[OldPos.Point.Y][OldPos.Point.X];
            btn.BackgroundImage = OldPos.Symbol;

            if (StkRedoStep.Count <= 0)
                CurrentPlayer = OldPos.CurrentPlayer == 1 ? 0 : 1;
            else
                OldPos = StkRedoStep.Peek();

            ChangePlayer();

            return true;
        }*/
        #endregion

        #region Duyệt nguyên stack undo cho mỗi lần nhấn 
        //hang ngang
        private bool CheckHorizontal(int X, int Y, Image PlayerSymbol)
        {
            int NumCellsToWin = 5;
            int Count;
            if (X > Cons.nRowsX && X < 0 || Y > Cons.nColsY && Y > 0)
                return false;

            for (Count = 1; Count < NumCellsToWin; Count++)
                if (MatrixPositions[X][Y + Count].BackgroundImage != PlayerSymbol)
                    return false;

            // Xét chặn 2 đầu
            if (Y == 0 || Y + Count == Cons.nColsY)
                return true;


            if (MatrixPositions[X][Y - 1].BackgroundImage == null || MatrixPositions[X][Y + Count].BackgroundImage == null)
            {
                for (Count = 0; Count < NumCellsToWin; Count++)
                    MatrixPositions[X][Y + Count].BackColor = Color.Lime;
                return true;
            }

            return false;
        }
        //hang doc
        private bool CheckVertical(int X, int Y, Image PlayerSymbol)
        {
            int NumCellsToWin = 5;
            int Count;

            if (X > Cons.nRowsX - 5)
                return false;

            for (Count = 1; Count < NumCellsToWin; Count++)
                if (MatrixPositions[X + Count][Y].BackgroundImage != PlayerSymbol)
                    return false;

            // Xét chặn 2 đầu
            if (X == 0 || X + Count == Cons.nRowsX)
                return true;

            if (MatrixPositions[X - 1][Y].BackgroundImage == null || MatrixPositions[X + Count][Y].BackgroundImage == null)
            {
                for (Count = 0; Count < NumCellsToWin; Count++)
                    MatrixPositions[X + Count][Y].BackColor = Color.Lime;
                return true;
            }

            return false;
        }

        private bool CheckMainDiag(int X, int Y, Image PlayerSymbol)
        {
            int NumCellsToWin = 5;
            int Count;

            if (X > Cons.nRowsX - 5 || Y > Cons.nColsY - 5)
                return false;

            for (Count = 1; Count < NumCellsToWin; Count++)
                if (MatrixPositions[X + Count][Y + Count].BackgroundImage != PlayerSymbol)
                    return false;

            // Xét chặn 2 đầu
            if (X == 0 || X + Count == Cons.nRowsX || Y == 0 || Y + Count == Cons.nColsY)
                return true;

            if (MatrixPositions[X - 1][Y - 1].BackgroundImage == null || MatrixPositions[X + Count][Y + Count].BackgroundImage == null)
            {
                for (Count = 0; Count < NumCellsToWin; Count++)
                    MatrixPositions[X + Count][Y + Count].BackColor = Color.Lime;
                return true;
            }

            return false;
        }

        private bool CheckExtraDiag(int X, int Y, Image PlayerSymbol)
        {
            int NumCellsToWin = 5;
            int Count;

            if (X < NumCellsToWin - 1 || Y > Cons.nColsY - NumCellsToWin)
                return false;

            for (Count = 1; Count < NumCellsToWin; Count++)
                if (MatrixPositions[X - Count][Y + Count].BackgroundImage != PlayerSymbol)
                    return false;

            // Xét chặn 2 đầu
            if (X == 4 || X == Cons.nRowsX - 1 || X == 0 || X + Count == Cons.nRowsX)
                return true;

            if (MatrixPositions[X + 1][Y - 1].BackgroundImage == null || MatrixPositions[X - Count][Y + Count].BackgroundImage == null)
            {
                for (Count = 0; Count < NumCellsToWin; Count++)
                    MatrixPositions[X - Count][Y + Count].BackColor = Color.Lime;
                return true;
            }

            return false;
        }

        private bool IsEndGame()
        {
            if (StkUndoStep.Count == Cons.nRowsX * Cons.nColsY)
            {
                MessageBox.Show("Hòa cờ !!!");
                return true;
            }

            bool IsWin = false;

            foreach (PlayInfo btn in StkUndoStep)
            {
                if (CheckHorizontal(btn.Point.Y, btn.Point.X, btn.Symbol))
                    IsWin = true;

                if (CheckVertical(btn.Point.Y, btn.Point.X, btn.Symbol))
                    IsWin = true;

                if (CheckMainDiag(btn.Point.Y, btn.Point.X, btn.Symbol))
                    IsWin = true;

                if (CheckExtraDiag(btn.Point.Y, btn.Point.X, btn.Symbol))
                    IsWin = true;
            }

            if (IsWin)
                return IsWin;
            return false;
        }
        #endregion
        #endregion

        #region 
        public void EndGame()
        {
            if (gameOver != null)
                gameOver(this, new EventArgs());
        }

        private void ChangePlayer()
        {
            PlayerName.Text = ListPlayers[CurrentPlayer].Name;
            Avatar.Image = ListPlayers[CurrentPlayer].Avatar;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.BackgroundImage != null)
                return; // Nếu ô đã được đánh thì ko cho đánh lại

            btn.BackgroundImage = ListPlayers[CurrentPlayer].Symbol;

            StkUndoStep.Push(new PlayInfo(GetButtonCoordinate(btn), CurrentPlayer, btn.BackgroundImage));
            StkRedoStep.Clear();

            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
            ChangePlayer();

            if (playerClicked != null)
                playerClicked(this, new BtnClickEvent(GetButtonCoordinate(btn)));

            if (IsEndGame())
                EndGame();
        }

        #endregion

    }
}