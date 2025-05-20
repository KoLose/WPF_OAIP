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

namespace firstPraktika.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class AuthorizePage : Page
    {
        public AuthorizePage()
        {
            InitializeComponent();
        }
        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            var login = LoginTb.Text;
            var password = PasswordTb.Password;
            var loginUser = "Admin";
            var passwordUser = "1111";
            if (login == loginUser && password == passwordUser)
            {
                MessageBox.Show("Здравствуй, Админ!");
            }
            else
            {
                MessageBox.Show("Пошёл отсюда вон!");
            }
        }
    }
}
