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
            Login = TextBoxLogin.Text;
            Password1 = TextBoxPassword1.Password;
            Password2 = TextBoxPassword2.Password;
            Email = TextBoxEmail.Text;
        }
    }
}
