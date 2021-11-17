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
using static Practic9.Abonents;

namespace Practic9
{
    /// <summary>
    /// Логика взаимодействия для AbonentDataInput.xaml
    /// </summary>
    public partial class AbonentDataInput : Window
    {
        public static Abonent _abonent = new Abonent();
        public AbonentDataInput()
        {
            InitializeComponent();
        }
        private void AddAbonent_Click(object sender, RoutedEventArgs e)
        {
            _abonent = new Abonent(Convert.ToInt32(phoneNumberInput.Text), nameInput.Text, addressInput.Text);
            Close();
        }
    }
}
