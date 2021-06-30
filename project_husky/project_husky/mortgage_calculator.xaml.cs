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

namespace project_husky
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class mortgage_calculator : Page
    {
        double loan_amount = 0.0;
        double loan_principal = 0.0;
        double monthly_interest = 0.0;
        int number_of_payments = 0;
        double monthly_payment_double;
        double loan_total_double;
        double total_interest_double;
        public mortgage_calculator()
        {
            this.InitializeComponent();
        }

        private void currency_convertor_page_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(currency_convertor));
        }

        private void mortgage_calculator_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(info));
        }

        private void stocks_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(stocks_main));
        }

        private void loan_amount_textbox_GotFocus(object sender, RoutedEventArgs e)
        {
            loan_amount_textbox.Text = "";
        }

        private void loan_fees_textbox_GotFocus(object sender, RoutedEventArgs e)
        {
            loan_principal_textbox.Text = "";
        }

        private void annual_interest_textbox_GotFocus(object sender, RoutedEventArgs e)
        {
            monthly_interest_textbox.Text = "";
        }

        private void number_of_years_textbox_GotFocus(object sender, RoutedEventArgs e)
        {
            number_of_payments_textbox.Text = "";
        }

        private void bitcoin_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void calculate_Tapped(object sender, TappedRoutedEventArgs e)
        {
            loan_amount = Convert.ToDouble(loan_amount_textbox.Text);
            loan_principal = Convert.ToDouble(loan_principal_textbox.Text);
            monthly_interest = Convert.ToDouble(monthly_interest_textbox.Text);
            number_of_payments = Int32.Parse(number_of_payments_textbox.Text);

            // Write your formula here
            if (loan_amount == 0 && loan_principal == 0 && monthly_interest == 0 && number_of_payments == 0)
            {
                monthly_payment_double = 0;
                loan_total_double = 0;
                total_interest_double = 0;
            }
            else
            {
                monthly_payment_double = loan_amount * ((monthly_interest * (Math.Pow(1 + monthly_interest, number_of_payments))) / (Math.Pow(1 + monthly_interest, number_of_payments) - 1));
                loan_total_double = monthly_payment_double * number_of_payments;
                total_interest_double = loan_total_double - loan_principal;
            }
            // Assign the result to those values
            monthly_payment_label.Text = "$ "+ monthly_payment_double.ToString("#.##");
            loan_total_label.Text = "$ " + loan_total_double.ToString("#.##");
            total_interest_label.Text = "$ " + total_interest_double.ToString("#.##");
        }

        private void reset_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            loan_amount_textbox.Text = "0";
            loan_principal_textbox.Text = "0";
            monthly_interest_textbox.Text = "0";
            number_of_payments_textbox.Text = "0";
            monthly_payment_label.Text = "0";
            loan_total_label.Text = "0";
            total_interest_label.Text = "0";
        }
    }
}
