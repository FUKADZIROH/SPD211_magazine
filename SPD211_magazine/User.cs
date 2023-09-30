using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPD211_magazine
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Middlename { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }

        public User(string name, string surname, string middlename, int age, string phoneNumber, string email, string userLogin, string userPassword)
        {
            Name = name;
            Surname = surname;
            Middlename = middlename;
            Age = age;
            PhoneNumber = phoneNumber;
            Email = email;
            UserLogin = userLogin;
            UserPassword = userPassword;
        }

       

        public override string ToString()
        {
            return $"ПІБ {Name} {Surname} {Middlename} Вік: {Age} \n" +
                $"Номер телефону:{PhoneNumber}\n" +
                $"{Email}";
        }
    }
    
}
