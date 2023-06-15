using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Text.Json;
using System.IO;
using System.Collections.ObjectModel;

namespace Header_EXAM
{
    /// <summary>
    /// Логика взаимодействия для Income_and_expenses.xaml
    /// </summary>
    public partial class Income_and_expenses : Window
    {
        List<My_money> users;
        public Income_and_expenses()
        {
            InitializeComponent();

            users = new List<My_money> 
            {
                new My_money() { Balance = -3500, Cause = "Продуктовый магазин", Date_change = new DateTime(2023, 5, 12) },
                new My_money() { Balance = -5000, Cause = "Ночной клуб", Date_change = new DateTime(2023, 5, 14) }, 
                new My_money() { Balance = -1500, Cause = "Картинг", Date_change = new DateTime(2023, 5, 16) },
            };
            DataContext = users;
        }

      

        private void Button_Click_SAVE(object sender, RoutedEventArgs e)
        {
            using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
            {

                JsonSerializer.SerializeAsync<List<My_money>>(fs, users);
                MessageBox.Show("Данные сохранены");
            }
            Close();
        }
    }
}
