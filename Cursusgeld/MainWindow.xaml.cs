using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cursusgeld
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

        double pricePerHour = 1.5;
        double hours;
        double money = 0;
        double year;
        bool isNumeriek1;
        bool isNumeriek2;
        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            money = hours * pricePerHour;
            if (year % 4 == 0)
            {
                money += pricePerHour;
                schrikkeljaar.Content = "Is een schrikkeljaar";

            }
            else
            {
                schrikkeljaar.Content = "Is geen schrikkeljaar";
            }

            moneyTextBox.Text = money.ToString("C");
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void testButton_Click(object sender, RoutedEventArgs e)
        {
            isNumeriek1 = double.TryParse(lesHoursTextBox.Text, out hours);
            isNumeriek2 = double.TryParse(yearTextBox.Text, out year);
            if (isNumeriek1 && isNumeriek2)
            {
                calculateButton.IsEnabled = true;
                numeriek.Content = "is numeriek";
            }
            else
            {
                calculateButton.IsEnabled = false;
                numeriek.Content = "is niet numeriek";
            }
        }
    }
}