namespace SPD211_magazine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AdminScreen adminScreen = new AdminScreen();
            adminScreen.Show();
        }
    }
}