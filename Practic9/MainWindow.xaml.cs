using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practic9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { DataTable table = new DataTable();
        public MainWindow()
        {
            InitializeComponent();
            table.Columns.Add("Номер телефона");
            table.Columns.Add("ФИО");
            table.Columns.Add("Адрес");
            abonentsGrid.ItemsSource = table.DefaultView;
        }

        private void AddAbonentToForm(object sender, RoutedEventArgs e)
        {
            AbonentDataInput abonentDataInput = new AbonentDataInput();
            if(abonentDataInput.ShowDialog() == false)
            {
                var tableRow = table.NewRow();
               tableRow[0] = AbonentDataInput._abonent.PhoneNumber;
                tableRow[1] = AbonentDataInput._abonent.Name;
                tableRow[2] = AbonentDataInput._abonent.Address;
                table.Rows.Add(tableRow);
                abonentsGrid.ItemsSource = table.DefaultView;

            }
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил Шестаков Артём ИСП-31 \nЗаполнить таблицу со списком телефонных абонентов на 7 человек с полями: ФИО, номер телефона, адрес.Вывести результат на экран.Вывести список абонентов живущих на заданной улице.");
        }
    }
}
