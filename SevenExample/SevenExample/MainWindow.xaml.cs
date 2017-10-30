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

namespace SevenExample
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Converter converter;
        public MainWindow()
        {
            InitializeComponent();
            converter = new Converter();
        }

        private void DataTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space || !(e.Key >= Key.D0 && e.Key <= Key.D9) && !(e.Key == Key.Back))
            {
                e.Handled = true;
            }
        }

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            converter._Convert(dayTextBox.Text, monthTextBox.Text, yearTextBox.Text);
            userDataPicker.SelectedDate = converter.ConvertedDate;
        }

        private void ConvertBackButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                converter.ConvertedDate = userDataPicker.SelectedDate.Value;
                converter._ConvertBack();
                yearTextBox.Text = converter.Year.ToString();
                monthTextBox.Text = converter.Month.ToString();
                dayTextBox.Text = converter.Day.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Вы не выбрали дату");
            }
        }
    }
}
