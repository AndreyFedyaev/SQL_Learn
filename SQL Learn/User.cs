using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Learn
{
    internal class User
    {
        private int ID { get; set; }
        private string Login, Password, email;

        public User() { }

        public User(string Login, string Password, string email)
        {
            this.Login = Login;
            this.Password = Password;
            this.email = email;
        }
        
    }
}
