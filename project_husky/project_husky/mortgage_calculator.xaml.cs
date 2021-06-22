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
        double loan_fees = 0.0;
        double annual_interest = 0.0;
        int number_of_years = 0;
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
            loan_fees_textbox.Text = "";
        }

        private void annual_interest_textbox_GotFocus(object sender, RoutedEventArgs e)
        {
            annual_interest_textbox.Text = "";
        }

        private void number_of_years_textbox_GotFocus(object sender, RoutedEventArgs e)
        {
            number_of_years_textbox.Text = "";
        }

        private void bitcoin_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void calculate_Tapped(object sender, TappedRoutedEventArgs e)
        {
            loan_amount = Convert.ToDouble(loan_amount_textbox.Text);
            loan_fees = Convert.ToDouble(loan_fees_textbox.Text);
            annual_interest = Convert.ToDouble(annual_interest_textbox.Text);
            number_of_years = Int32.Parse(number_of_years_textbox.Text);

            // Write your formula here

            // Assign the result to those values
            monthly_payment_label.Text = "";
            total_amount_label.Text = "";
            interest_label.Text = "";
        }
    }
}
