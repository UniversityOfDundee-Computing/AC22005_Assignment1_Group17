using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC22005_Assignment1
{
    internal class Cell
    {
        public bool isMine;
        public int adjacentMines;
        public Button button;
        private string textVal;
        private bool isFlagged = false;
        public Action<object> endGame;

        public Cell(bool _isMine)
        {
            this.isMine = _isMine;
            button = new Button();
            button.Width = GlobalVars.BUTTON_WIDTH;
            button.Height = GlobalVars.BUTTON_HEIGHT;
            button.MouseUp += button_click;
            if (this.isMine)
            {
                button.Text = "X";
                button.BackColor = Color.Red;
            } else
            {
                button.Text = "O";
                button.BackColor = Color.Blue;
            }
        }

        public void button_click(System.Object sender, EventArgs _e) 
        {
            // https://stackoverflow.com/questions/19448346/how-to-get-a-right-click-mouse-event-changing-eventargs-to-mouseeventargs-cause/19448432
            var e = (MouseEventArgs) _e;
            switch (e.Button)
            {
                case MouseButtons.Left:
                    // Left click
                    leftClick(sender, e);
                    break;

                case MouseButtons.Right:
                    // Right click
                    rightClick(sender, e);
                    break;
            }
         
        }

        private void leftClick(System.Object sender, MouseEventArgs e)
        {
            if (isFlagged) return;

            if (this.isMine)
            {
                Console.WriteLine("Loser");
            }
            else
            {
                button.Enabled = false;
                button.Text = adjacentMines.ToString();
                button.BackColor = Color.White;
            }
        }

        public void rightClick(System.Object sender, System.EventArgs e)
        {
            Console.WriteLine("Rightclicked");
            textVal = button.Text;
            if (!isFlagged)
            {
                button.Text = "A";
                isFlagged = true;
            }
            else
            {
                button.Text = textVal;
                isFlagged = false;
            }
        }
    }
}
