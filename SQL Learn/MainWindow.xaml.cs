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
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string Login, Password1, Password2, Email;
            Login = TextBoxLogin.Text.Trim();
            Password1 = TextBoxPassword1.Password.Trim();
            Password2 = TextBoxPassword2.Password.Trim();
            Email = TextBoxEmail.Text.Trim().ToLower();

            ///
            if (Login.Length < 3)
            {
                TextBoxLogin.ToolTip = "Необходимо ввести не менее 3 символов";
                TextBoxLogin.Background = Brushes.DarkRed;
            }
            else
            {
                TextBoxLogin.ToolTip = "";
                TextBoxLogin.Background = Brushes.Transparent;
            }
            ///
            if (Password1.Length < 6)
            {
                TextBoxPassword1.ToolTip = "Необходимо ввести не менее 6 символов";
                TextBoxPassword1.Background = Brushes.DarkRed;
            }
            else
            {
                TextBoxPassword1.ToolTip = "";
                TextBoxPassword1.Background = Brushes.Transparent;
            }
            ///
            if (Password1 != Password2)
            {
                TextBoxPassword2.ToolTip = "Пароли не совпадают";
                TextBoxPassword2.Background = Brushes.DarkRed;
            }
            else
            {
                TextBoxPassword2.ToolTip = "";
                TextBoxPassword2.Background = Brushes.Transparent;

            }
            ///
            if (!Email.Contains("@") || !Email.Contains("."))
            {
                TextBoxEmail.ToolTip = "Некорректно введен Email";
                TextBoxEmail.Background = Brushes.DarkRed;
            }
            else
            {
                TextBoxEmail.ToolTip = "";
                TextBoxEmail.Background = Brushes.Transparent;
            }
        }
    }
}
