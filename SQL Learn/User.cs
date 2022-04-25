using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Learn
{
    internal class User
    {
        public int ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
public User() { }

        public User(string Login, string Password, string Email)
        {
            this.Login = Login;
            this.Password = Password;
            this.Email = Email;
        }
        public User(int ID)
        {
            this.ID = ID;
        }
        public override string ToString()
        {
            return "логин: " + Login;
        }
    }
}
