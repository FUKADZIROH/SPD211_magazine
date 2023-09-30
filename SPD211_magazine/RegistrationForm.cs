using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPD211_magazine
{
    public partial class RegistrationForm : Form
    {
        User user;
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void AddNewUser(object sender, EventArgs e)
        {
            string enteredUsername = tb_Name.Text;
            string enteredSurname = tb_Surname.Text;
            string enteredMiddlename = tb_Middlename.Text;
            int enteredAge = Convert.ToInt32(tb_Age.Text);
            string enteredPhoneNumber = tb_PhoneNumber.Text;
            string enteredEmail = tb_Email.Text;
            string enteredUserLogin = tb_UserLogin.Text;
            string enteredPassword = tb_UserPassword.Text;
            string enteredPassword2 = tb_UserPasswordConfirm.Text;

            if (enteredPassword == enteredPassword2)
            {
                user = new User(enteredUsername, enteredSurname, enteredMiddlename, enteredAge, enteredPhoneNumber, enteredEmail, enteredUserLogin, enteredPassword);
                MessageBox.Show(user.ToString(), "Зареєстровано нового юзера", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Паролі не співпадають");
            }
        }




    }
}
