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
    public sealed partial class info : Page
    {
        public info()
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(join_studio));
        }

        private void stocks_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(stocks_main));
        }

        private void bitcoin_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void email_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var emailMessage = new Windows.ApplicationModel.Email.EmailMessage();

            var emailRecipient = new Windows.ApplicationModel.Email.EmailRecipient("dacikbas@umich.edu");
            emailMessage.To.Add(emailRecipient);

            Windows.ApplicationModel.Email.EmailManager.ShowComposeNewEmailAsync(emailMessage);
        }

        private void rate_us_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var dialog = new MessageDialog("This part of this application is under construction. When we release the next build, you will be able to use this part of the application.","Under Construction");
            dialog.ShowAsync();
        }
    }
}
