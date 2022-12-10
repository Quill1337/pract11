using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using System.Text.RegularExpressions;

namespace pract11
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
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            listBoxNumbers.Items.Clear();
        }

        private void FindingTheFirstLine_Click(object sender, RoutedEventArgs e)
        {
            ResStrTextBox.Clear();
            Regex regex = new Regex(@"2[+]3"); //Строку 2+3 не захватив остальные
            MatchCollection matchCollection = regex.Matches(FirStr.Text);
            object[] mas = new object[matchCollection.Count];
            matchCollection.CopyTo(mas, 0);
            foreach (object item in mas)
            {
                ResStrTextBox.Text = $"{item}";
            }
        }

        private void FindingTheSecondLine_Click(object sender, RoutedEventArgs e)
        {
                    ResStrTextBox.Clear();
            Regex regex = new Regex(@"ab{2,4}a"); //строки abba, abbba, abbbba и только их.
            MatchCollection matchCollection = regex.Matches(SecStr.Text);
            object[] mas = new object[matchCollection.Count];
            matchCollection.CopyTo(mas, 0);
            foreach (object item in mas)
            {
                ResStrTextBox.Text = $" {item} " + ResStrTextBox.Text;
            }
        }
        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Митрофанов Роман ИСП-31\n Дана строка '2+3 223 2223'.\n Напишите регулярное выражение, которое найдет строку 2+3, не захватив остальные.\nДана строка 'aa aba abba abbba abbbba abbbbba'. Напишите регулярное выражение, \nкоторое найдет строки abba, abbba, abbbba и только их.");
        }
    }
}
