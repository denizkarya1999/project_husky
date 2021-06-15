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
    public sealed partial class stocks_main : Page
    {
        public stocks_main()
        {
            this.InitializeComponent();
        }


        private void currency_convertor_page_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(currency_convertor));
        }

        private void mortgage_calculator_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(mortgage_calculator));
        }

        private void info_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(info));
        }

        private void mortgage_calculator_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(mortgage_calculator));
        }

        private void industrial_performance_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Stocks));
        }

        private void web_home_Tapped(object sender, TappedRoutedEventArgs e)
        {
            webView1.Navigate(new Uri("https://www.nasdaq.com/market-activity/stocks"));
        }

        private void web_go_Tapped(object sender, TappedRoutedEventArgs e)
        {
            webView1.GoForward();
        }

        private void web_back_Tapped(object sender, TappedRoutedEventArgs e)
        {
            webView1.GoBack();
        }

        private void web_refresh_Tapped(object sender, TappedRoutedEventArgs e)
        {
            webView1.Refresh();
        }

        private void bitcoin_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
