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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UIDESIGN
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            
        }
        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (Customer.IsSelected) { ResultTextBlock.Text = "Share"; }
            //else if (Vendor.IsSelected) { ResultTextBlock.Text = "Favorites"; }
            if (Customer.IsSelected)
            {
                //BackButton.Visibility = Visibility.Collapsed;
                MyFrame.Navigate(typeof(Customer));
                TitleTextBlock.Text = "Customer";
            }
            else if (Vendor.IsSelected)
            {
                //BackButton.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(Vendor));
                TitleTextBlock.Text = "Vendor";
            }
        }
    }
}
