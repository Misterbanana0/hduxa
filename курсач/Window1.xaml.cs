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
using System.Windows.Shapes;

namespace курсач
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(LoginTextBox.Text))
            {
                if (!String.IsNullOrEmpty(passwordTextbox.Password))
                {
                    IQueryable<авторизация> Авторизация_list = Class1.GetContext().авторизация.Where(p => p.Логин == LoginTextBox.Text && p.Пароль == passwordTextbox.Password);
                    if (Авторизация_list.Count() == 1)
                    {
                        MessageBox.Show(" Вечер в хату " + Авторизация_list.First().Логин);
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                        this.Close();
                    }

                }
                else MessageBox.Show("Неверный пароль или логин!");
            }
        }

        private void LoginTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

