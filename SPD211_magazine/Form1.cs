
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
        public static List<User> registeredUsers = new List<User>();
        public Form1()
        {
            InitializeComponent();
        }

        private void RedisterAnAccount(object sender, EventArgs e)
        {
            Navigator.GoToRegisterScreen();
        }

        private void SingInAccount(object sender, EventArgs e)
        {
            string enteredUsername = tb_1.Text;
            string enteredPassword = tb_2.Text;

            bool isValid = false;
            bool isAdmin = false;

            if (userCredentials.ContainsKey(enteredUsername) && userCredentials[enteredUsername] == enteredPassword)
            {
                isValid = true;
                MessageBox.Show("You are logged in as a user!");
                Navigator.GoToUserScreen();
            }
            else if (adminCredentials.ContainsKey(enteredUsername) && adminCredentials[enteredUsername] == enteredPassword)
            {
                isValid = true;
                MessageBox.Show("You are logged in as an administrator!");
                Navigator.GoToAdminScreen();
            }
            else if (UserExists(enteredUsername, enteredPassword))
            {
                isValid = true;
                isAdmin = IsUserAdmin(enteredUsername);
                if (isAdmin)
                {
                    MessageBox.Show("You are logged in as an administrator!");
                    Navigator.GoToAdminScreen();
                }
                else
                {
                    Navigator.GoToUserScreen();
                    MessageBox.Show("You are logged in as a user!");
                }
            }

            if (!isValid)
            {
                MessageBox.Show("Your login or password is incorrect. Please try again.");
            }
        }
        private bool UserExists(string enteredUsername, string enteredPassword)
        {
            foreach (var user in registeredUsers)
            {
                if (user.UserLogin == enteredUsername && user.UserPassword == enteredPassword)
                {
                    return true;
                }
            }

            return false;
        }
        private bool IsUserAdmin(string username)
        {
            foreach (var user in Form1.registeredUsers)
            {
                if (user.UserLogin == username && user.IsAdmin)
                {
                    return true;
                }
            }

            return false;
        }
    }
}