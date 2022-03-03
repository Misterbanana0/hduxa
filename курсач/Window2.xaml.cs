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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            Update();
        }
        private void Update()
        {
            var join_massive = from Заказы in Class1.GetContext().Заказы
                               join Клиeнты in Class1.GetContext().Клиенты on Заказы.Клиент equals Клиeнты.id_клиента
                               join Статусы_заказов in Class1.GetContext().Статусы_заказов on Заказы.id_статус_заказов equals Статусы_заказов.id_статуса_заказа
                               select new
                               {
                                   id_заказа = Заказы.id_заказа,
                                   Дата_исполнение = Заказы.Дата_исполнения,
                                   Номер_Договора = Заказы.Номер_Договора,
                                   Клиент = Заказы.Клиент,
                                   Дата_создания = Заказы.Дата_создания,
                                   id_статус_заказов = Заказы.id_статус_заказов,
                                   id_Услуги = Заказы.id_Услуги

                               };
            dataGridZakaz.ItemsSource = join_massive.ToList();

        }
    }
}
