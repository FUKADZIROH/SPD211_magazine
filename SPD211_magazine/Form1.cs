
namespace SPD211_magazine
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> userCredentials = new Dictionary<string, string>
        {
            { "user1", "password1" },
            { "user2", "password2" },
        };

        private Dictionary<string, string> adminCredentials = new Dictionary<string, string>
        {
            { "admin1", "adminpassword1" },
            { "admin2", "adminpassword2" },
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void SingInAccount(object sender, EventArgs e)
        {
            string enteredUsername = tb_1.Text;
            string enteredPassword = tb_2.Text;

            bool isValid = false;

            if (userCredentials.ContainsKey(enteredUsername) && userCredentials[enteredUsername] == enteredPassword)
            {
                isValid = true;
                MessageBox.Show("You are logged in as a user!");
                //GoToUserScreen();            
            }
            else if (adminCredentials.ContainsKey(enteredUsername) && adminCredentials[enteredUsername] == enteredPassword)
            {
                isValid = true;
                MessageBox.Show("You are logged in as an administrator!");
                //GoToUserScreen();
            }
            if (!isValid)
            {
                MessageBox.Show("Your login or password is incorrect. Please try again.");
            }
        }

        private void RedisterAnAccount(object sender, EventArgs e)
        {
            //GoToRegisterScreen();
        }
    }
}