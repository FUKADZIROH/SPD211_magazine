using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPD211_magazine
{
    public static class Navigator
    {
        //function to go to the AdmainScreen
        public static void GoToAdminScreen()
        {
           /* AdminScreen admainScreen = new AdminScreen();
            adminScreen.Show();*/
        }
        //function to go to the UserScreen
        public static void GoToUserScreen()
        {
            /*UserScreen userScreen = new UserScreen();
             userScreen.Show();*/
        }
        //function to go to the RegisterScreen
        public static void GoToRegisterScreen()
        {
            RegistrationForm registerScreen = new RegistrationForm();
            registerScreen.Show();
        }
        //function to go to the LoginScreen
        public static void GoToLoginScreen()
        {
            Form1 loginScreen = new Form1();
            loginScreen.Show();
        }
    }
}
