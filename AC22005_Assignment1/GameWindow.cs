using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AC22005_Assignment1
{
    public partial class GameWindow : Form
    {
        public int rowCount;
        public int colCount;
        public int mineCount;
        private Cell[,] cells;
        //public TimeSpan timeLimit;
        public GameWindow(int r, int c, int m)
        {
            rowCount = r;
            colCount = c;
            mineCount = m;
            InitializeComponent();
        }
        public GameWindow()
        {
            rowCount = 10;
            colCount = 10;
            mineCount = 10;
            InitializeComponent();
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            cells = new Cell[rowCount, colCount];
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    int rand = rnd.Next(1, 10);
                    cells[i, j] = new Cell(rand == 1);
                    cells[i, j].button.Left = i * GlobalVars.BUTTON_WIDTH;
                    cells[i, j].button.Top = j * GlobalVars.BUTTON_HEIGHT;
                    cells[i, j].endGame = this.EndGame;

                    // Important to capture the value of i and j
                    //int a = i;
                    //int b = j;

                    //cells[i, j].button.Click += (sender, e) => ClickHandler(sender, e, a, b);
                    Controls.Add(cells[i, j].button);
                }
            }
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    cells[i, j].adjacentMines = CalculateAdjacentMines(i, j);
                }
            }
        }

        private int CalculateAdjacentMines(int i, int j)
        {
            int adjMines = 0;
            for (int iMod = -1; iMod <= 1; iMod++)
            {
                for (int jMod = -1; jMod <= 1; jMod ++)
                {
                    if (iMod == 0 && jMod == 0) continue;
                    try
                    {
                        var cell = cells[i + iMod, j + jMod];
                        if (cell.isMine) adjMines++;
                    }
                    catch (IndexOutOfRangeException _e) 
                    {
                        // Just to catch IndexOutOfBounds
                    }
                }
            }
            return adjMines;
        }
        
        private void EndGame(object details)
        {
            //Win
            Console.WriteLine("Game ended");
        }
        
    }
}
