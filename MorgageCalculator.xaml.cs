using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Tafe_Universal_Calculator
{
    /// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MorgageCalculator : Page
    {
        public MorgageCalculator()
        {
            this.InitializeComponent();
        }

        private double interestRepayment(double principalLoanAmount, int years, int months, double interestRateM)
        {
            int yearsInMonths = 12 * years;
            int n = yearsInMonths + months;
            double RepayAmount = principalLoanAmount * ((interestRateM) *(1 + Math.Pow(interestRateM, n))) / (1 + Math.Pow(interestRateM, n));
            return RepayAmount;

        }

        private void calButton_Click(object sender, RoutedEventArgs e)
        {
            double principalLoanAmount;
            int years;
            int months;
            double interestRateY;
            double interestRateM;
            double repayment;

            years = int.Parse(yearsTextBox.Text);
            months = int.Parse(monthsTextBox.Text);

            interestRateY = double.Parse(iRYTextBox.Text);

            principalLoanAmount = double.Parse(principalAmount.Text);

            interestRateM = interestRateY / 12;

            repayment = interestRepayment(principalLoanAmount, years, months, interestRateM);

            IRMTextBox.Text = interestRateM.ToString() + "%";

            repaymentMTextBox.Text = repayment.ToString();



        }

        private void HyperlinkButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Navigate back to sub.xaml page.
            this.Frame.Navigate(typeof(MainMenu));
        }



    }
}
