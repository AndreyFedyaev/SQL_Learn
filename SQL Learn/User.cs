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
        private string login, password, email;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public User() { }

        public User(string Login, string Password, string Email)
        {
            this.login = Login;
            this.password = Password;
            this.email = Email;
        }
        
    }
}
