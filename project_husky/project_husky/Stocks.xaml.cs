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
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace project_husky
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Stocks : Page
    {
        public Stocks()
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

        private void stocks_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(stocks_main));
        }

        private void bitcoin_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void web_home_Tapped(object sender, TappedRoutedEventArgs e)
        {
            webView1.Navigate(new Uri("https://www.tradingview.com/markets/stocks-usa/sectorandindustry-sector/"));
        }

        private void web_go_Tapped(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                webView1.GoForward();
            }
            catch (Exception ex)
            {
                var dialog = new MessageDialog("You cannot go forward from this page since this is the last page.", "Navigation Error");
                dialog.ShowAsync();
            }
        }

        private void web_back_Tapped(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                webView1.GoBack();
            }
            catch (Exception ex)
            {
                var dialog = new MessageDialog("You cannot go back from this page since this is the first page.", "Navigation Error");
                dialog.ShowAsync();
            }
        }
        private void web_refresh_Tapped(object sender, TappedRoutedEventArgs e)
        {
            webView1.Refresh();
        }
    }
}
