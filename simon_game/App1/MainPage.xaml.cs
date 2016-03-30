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

        int[] generatedColorSequence; //array to store the generated sequence
        int[] usersGuessSequence; //array to store the users input

        int generatedColorSequenceIndex = 0; //need to keep track of index to play animation
        int usersGuessSequenceIndex = 0; //keep track of users input to compare to generated

        int sequenceLength = 0;

        //int mi = 0;

        public MainPage()
        {
            this.InitializeComponent();

            r = new Random(); //seeded random number based on time

            generatedColorSequence = new int[MAX]; //set to max to generate random number
            usersGuessSequence = new int[MAX];
            createColorSequence(); //generate a sequence when they start the application

            txtTurnNumber.Visibility = Visibility.Collapsed; //set counter to collapsed when application starts

        }

        private void blueRect_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //animate opacity
            storyboardBlueRect.Begin(); //start animation when shape is tapped/clicked
        }

        private void yelowRect_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //txtRandom.Text = generatedColorSequence[mi].ToString();
            //mi++;
            storyboardYellowRect.Begin(); //start animation when shape is tapped/clicked
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
            //txtStart.Visibility = Visibility.Collapsed;
            //start game
            if (txtStart.Text == "Tap to Start")
            {
                if (txtStart.Visibility != Visibility.Collapsed) //if the game has not already been started
                {
                    txtRandom.Text = "yay!!";
                    play(); //start the game
                }
            }
            else if (txtStart.Text != "Tap to Start") //which means its equal to winner
            {
                gameOver();
            }
            //will change text to winner if hits max.. then txtStart wont equal Tap to start
            else
            {
            }
        }
        private void play()
        {
            //initialise variables here
            int sequenceLength = 0;
            txtTurnNumber.Text = sequenceLength.ToString(); //set the turn number to current sequence length
            usersGuessSequenceIndex = 0;
            createColorSequence(); //do this incase they have started a new game

            txtTurnNumber.Visibility = Visibility.Visible; //set counter to Visible when the game starts
            txtStart.Visibility = Visibility.Collapsed; //set Start text to collapsed when the game starts
        }
        private void gameOver()
        {
            //initialise variables here
            txtTurnNumber.Visibility = Visibility.Collapsed; //set counter to collapsed when the game ends
            txtStart.Visibility = Visibility.Visible; //set Start text to visible when the game ends
        }
        private void storyboardGreenRectAnimationFin(object sender, object e)
        {
            playGeneratedSequence();
        }
        private void storyboardRedRectAnimationFin(object sender, object e)
        {
            playGeneratedSequence();
        }
        private void storyboardYellowRectAnimationFin(object sender, object e)
        {
            playGeneratedSequence();
        }
        private void storyboardBlueRectAnimationFin(object sender, object e)
        {
            playGeneratedSequence();
        }

        private void createColorSequence()
        {
            //generate a random number to represent colours
            for (int i = 0; i < MAX; i++)
            {
                //generating entire sequence
                generatedColorSequence[i] = r.Next(1, NUMBER_OF_COLORS+1); //generate random number and store it in the generatedSeq array
                usersGuessSequence[i] = 0;
            }
        }

        private void playGeneratedSequence()
        {
            if (generatedColorSequence[generatedColorSequenceIndex] == 1)
            {
                storyboardGreenRect.Begin();
            }
            else if (generatedColorSequence[generatedColorSequenceIndex] == 2)
            {
                storyboardRedRect.Begin();
            }
            else if (generatedColorSequence[generatedColorSequenceIndex] == 3)
            {
                storyboardYellowRect.Begin();
            }
            else if (generatedColorSequence[generatedColorSequenceIndex] == 4)
            {
                storyboardBlueRect.Begin();
            }
            generatedColorSequenceIndex++;
        }

    }
}
