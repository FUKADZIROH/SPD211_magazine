using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPD211_magazine
{
    public class Navigator
    {
        //function to go to the AdmainScreen
        public void GoToAdmainScreen()
        {
           /* AdmainScreen admainScreen = new AdmainScreen();
            admainScreen.Show();*/
        }
        //function to go to the UserScreen
        public void GoToUserScreen()
        {
            /*UserScreen userScreen = new UserScreen();
             userScreen.Show();*/
        }
        //function to go to the RegisterScreen
        public void GoToRegisterScreen()
        {
            /*RegisterScreen registerScreen = new RegisterScreen();
             registerScreen.Show();*/
        }
        //function to go to the LoginScreen
        public void GoToLoginScreen()
        {
            Form1 loginScreen = new Form1();
            loginScreen.Show();
        }
    }
}
