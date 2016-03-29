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
        const int NUMBER_OF_COLORS = 4; //representing the colours as a number instead of a string
        const int COLOR1 = 1; //red
        const int COLOR2 = 2; //green
        const int COLOR3 = 3; //blue
        const int COLOR4 = 4; //yellow
        const int MAX = 50; //max sequence allowed (50 animatons in a row)

        Random r;

        int[] correctColorSequence; //array to store the generated sequence
        int[] playerColorSequence; //array to store the users input

        public MainPage()
        {
            this.InitializeComponent();

            r = new Random(); //seeded random number based on time

            correctColorSequence = new int[MAX]; //set to max to generate random number
            playerColorSequence = new int[MAX];
        }

        private void blueRect_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //animate opacity
            storyboardBlueRect.Begin(); //start animation when shape is tapped/clicked
        }

        private void yelowRect_Tapped(object sender, TappedRoutedEventArgs e)
        {
            storyboardYellowRect.Begin(); //start animation when shape is tapped/clicked
            createColorSequence(); //call random number generator method
        }

        private void greenRect_Tapped(object sender, TappedRoutedEventArgs e)
        {
            storyboardGreenRect.Begin(); //start animation when shape is tapped/clicked
        }

        private void redRect_Tapped(object sender, TappedRoutedEventArgs e)
        {
            storyboardRedRect.Begin(); //start animation when shape is tapped/clicked
        }

        private void Tapped_txtStart(object sender, TappedRoutedEventArgs e)
        {
            //start game
        }
        private void storyboardGreenRectAnimationFin(object sender, object e)
        {

        }
        private void storyboardRedRectAnimationFin(object sender, object e)
        {

        }
        private void storyboardYellowRectAnimationFin(object sender, object e)
        {

        }
        private void storyboardBlueRectAnimationFin(object sender, object e)
        {

        }

        private void createColorSequence()
        {
            //generate a random number to represent colours
            for (int i = 0; i < MAX; i++)
            {
                correctColorSequence[i] = r.Next(1, NUMBER_OF_COLORS+1); //generate random number and store it in the correctSeq array
                playerColorSequence[i] = 0;
                txtRandom.Text = correctColorSequence[i].ToString(); //put number out to textbox for testing purposes
            }
        }
    }
}
