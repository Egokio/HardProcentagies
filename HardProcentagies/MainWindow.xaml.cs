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

namespace HardProcentagies
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


        private void Money_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Period_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Rate_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Computing_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(Money.Text, out double moneyInput) || moneyInput <= 0)
            {
               
                    MessageBox.Show("Type correct amount!");
                    return;
                
            }

            if (!int.TryParse(PeriodMonths.Text, out int periodMonthsInput) || periodMonthsInput <= 0)
            {
             
                    MessageBox.Show("Wrong month input");
                    return;
                
            }
            if (!double.TryParse(Rate.Text, out double rateInput) || rateInput <= 0)
            {

                    MessageBox.Show("Wrong rate input");
                    return;
                
            }
            var (totalMoney, incomePercentage, income) = Calculator.CountPercentage(rateInput, moneyInput, periodMonthsInput);
            TotalAmount.Content = totalMoney.ToString();
            PercentIncome.Content = incomePercentage.ToString();
            MoneyIncome.Content = income.ToString();
        }
    }
}