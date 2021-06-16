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
    public sealed partial class currency_convertor : Page
    {
        public currency_convertor()
        {
            this.InitializeComponent();
        }

        private void convert_from_textbox_GotFocus(object sender, RoutedEventArgs e)
        {
            convert_from_textbox.Text = " ";
        }

        private void mortgage_calculator_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(mortgage_calculator));
        }

        private void info_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(info));
        }

        private void stocks_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(stocks_main));
        }

        private void bitcoin_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void calculate_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void reset_Tapped(object sender, TappedRoutedEventArgs e)
        {
            convert_from_textbox.Text = "Enter Amount:";
            convert_from.SelectedIndex = -1;
            convert_to.SelectedIndex = -1;
        }
    }
}
