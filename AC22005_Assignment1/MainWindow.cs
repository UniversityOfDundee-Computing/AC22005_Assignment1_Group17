namespace AC22005_Assignment1
{
    public partial class MainWindow : Form
    {
        private int rowCount = 10;
        private int colCount = 10;
        private int mineCount = 10;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GameWindow gameWindow = new GameWindow(rowCount, colCount, mineCount);
            //this.Close();
            gameWindow.Show();
            gameWindow.Activate();


        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            numericUpDown1.Value = trackBar1.Value;
            rowCount = trackBar1.Value;
            label4.Text = rowCount.ToString();
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           trackBar1.Value = Decimal.ToInt32(numericUpDown1.Value);
           rowCount = Decimal.ToInt32(numericUpDown1.Value);
            label4.Text = rowCount.ToString();

        }

        private void trackbar2_scroll(object sender, EventArgs e)
        {
            numericUpDown2.Value = trackBar2.Value;
            colCount = trackBar2.Value;
            label5.Text = colCount.ToString();

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            trackBar2.Value = Decimal.ToInt32(numericUpDown2.Value);
            colCount = Decimal.ToInt32(numericUpDown2.Value);
            label5.Text = colCount.ToString();

        }


        private void trackbar3_scroll(object sender, EventArgs e)
        {
            numericUpDown3.Value = trackBar3.Value;
            mineCount = trackBar3.Value;
            label6.Text = mineCount.ToString();

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            trackBar3.Value = Decimal.ToInt32(numericUpDown3.Value);
            mineCount = Decimal.ToInt32(numericUpDown3.Value);
            label6.Text = mineCount.ToString();

        }


    }
}