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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        string[] colors;
        Random r;
        public MainPage()
        {
            this.InitializeComponent();

            colors = new string[]
            {"red", "blue", "yellow", "green"};

            r = new Random();
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            int randomNum = r.Next(0, colors.Length);
            txtRandom.Text = colors[randomNum];
        }

        private void BlueRect_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void YelowRect_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void greenRect_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void RedRect_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }
    }
}
