using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SQL_Learn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AppContext db;

        public MainWindow()
        {
            InitializeComponent();
            db = new AppContext();
            List<User> EEE = db.Users.ToList();

           
        }

        private void Button_Window_Auth_Click(object sender, RoutedEventArgs e)
        {
            Window1 mainWindow1 = new Window1();
            mainWindow1.Show();
            Hide();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
         {
            string Login, Password1, Password2, Email;
            Login = TextBoxLogin.Text.Trim();
            Password1 = TextBoxPassword1.Password.Trim();
            Password2 = TextBoxPassword2.Password.Trim();
            Email = TextBoxEmail.Text.Trim().ToLower();
            bool Error;
            ///
            if (Login.Length < 3)
            {
                TextBoxLogin.ToolTip = "Необходимо ввести не менее 3 символов";
                TextBoxLogin.Background = Brushes.Crimson;
                Error = true;
            }
            else
            {
                TextBoxLogin.ToolTip = null;
                TextBoxLogin.Background = Brushes.Transparent;
                Error = false;
            }
            ///
            if (Password1.Length < 6)
            {
                TextBoxPassword1.ToolTip = "Необходимо ввести не менее 6 символов";
                TextBoxPassword1.Background = Brushes.Crimson;
                Error = true;
            }
            else
            {
                TextBoxPassword1.ToolTip = null;
                TextBoxPassword1.Background = Brushes.Transparent;
                Error = false;
            }
            ///
            if (Password1 != Password2)
            {
                TextBoxPassword2.ToolTip = "Пароли не совпадают";
                TextBoxPassword2.Background = Brushes.Crimson;
                Error = true;
            }
            else
            {
                TextBoxPassword2.ToolTip = null;
                TextBoxPassword2.Background = Brushes.Transparent;
                Error = false;
            }
            ///
            if (!Email.Contains("@") || !Email.Contains("."))
            {
                TextBoxEmail.ToolTip = "Некорректно введен Email";
                TextBoxEmail.Background = Brushes.Crimson;
                Error = true;
            }
            else
            {
                TextBoxEmail.ToolTip = null;
                TextBoxEmail.Background = Brushes.Transparent;
                Error = false;
            }

            if (Error == false)
            {
                User user = new User(Login, Password2, Email);
                db.Users.Add(user);
                db.SaveChanges();

                Window1 mainWindow1 = new Window1();
                mainWindow1.Show();
                Hide();
            }
        }
    }
}
