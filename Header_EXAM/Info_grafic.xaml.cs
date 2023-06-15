using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Header_EXAM
{
    /// <summary>
    /// Логика взаимодействия для Info_grafic.xaml
    /// </summary>
    public partial class Info_grafic : Window
    {
        List<Money_3_YEAR> list;
        int sum_2021 = 0, sum_2022 = 0, sum_2023 = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public Info_grafic()
        {
            InitializeComponent();

            list = new List<Money_3_YEAR>
            {
                new Money_3_YEAR() { Month = "январь", Money_2021 = -2500, Money_2022 = 1800, Money_2023 = 2800 },
                new Money_3_YEAR() { Month = "февраль", Money_2021 = -1700, Money_2022 = 1900, Money_2023 = 25000 },
                new Money_3_YEAR() { Month = "март", Money_2021 = 12000, Money_2022 = -25000, Money_2023 = 17000 },
                new Money_3_YEAR() { Month = "апрель", Money_2021 = 17500, Money_2022 = 17520, Money_2023 = 26870 },
                new Money_3_YEAR() { Month = "май", Money_2021 = 14200, Money_2022 = 25000, Money_2023 = -8522 },
                new Money_3_YEAR() { Month = "июнь", Money_2021 = -13520, Money_2022 = -14520, Money_2023 = 29000 },
                new Money_3_YEAR() { Month = "июль", Money_2021 = -14700, Money_2022 = -7850 },
                new Money_3_YEAR() { Month = "август", Money_2021 = -8700, Money_2022 = 29860 },
                new Money_3_YEAR() { Month = "сентябрь", Money_2021 = 47000, Money_2022 = 28560 },
                new Money_3_YEAR() { Month = "октябрь", Money_2021 = 27000, Money_2022 = -19850 },
                new Money_3_YEAR() { Month = "ноябрь", Money_2021 = -13850, Money_2022 = 10000 },
                new Money_3_YEAR() { Month = "декабрь", Money_2021 = -14900, Money_2022 = 5000 },

            };
            foreach (var item in list)
            {
                sum_2021 += item.Money_2021;
                sum_2022 += item.Money_2022;
                sum_2023 += item.Money_2023;
            }
            list.Add(new Money_3_YEAR() { Month = "итого", Money_2021 = sum_2021, Money_2022 = sum_2022, Money_2023 = sum_2023 });
            DataContext = list;

        }

      
    }
}
