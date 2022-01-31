namespace AC22005_Assignment1
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GameWindow gameWindow = new GameWindow();
            //this.Close();
            gameWindow.Show();
            gameWindow.Activate();


        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
        private int rowCount = 10;
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            numericUpDown1.Value = trackBar1.Value;
            rowCount = trackBar1.Value;
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           trackBar1.Value = Decimal.ToInt32(numericUpDown1.Value);
           rowCount = Decimal.ToInt32(numericUpDown1.Value);
        }

       
    }
}