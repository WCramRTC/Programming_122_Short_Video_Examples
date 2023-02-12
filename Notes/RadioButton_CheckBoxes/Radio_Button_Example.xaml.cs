using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Short_Video_Examples.Notes.RadioButton_CheckBoxes
{
    /// <summary>
    /// Interaction logic for Radio_Button_Example.xaml
    /// </summary>
    public partial class Radio_Button_Example : Window
    {
        public Radio_Button_Example()
        {
            InitializeComponent();
        }

        private void btnSize_Click(object sender, RoutedEventArgs e)
        {
            // Radio buttons always return TRUE or FALSE - Booleans
            // In order to get the result of our radio button, use name.isChecked.Value
            bool small = rbSmall.IsChecked.Value;
            bool medium = rbMedium.IsChecked.Value;
            bool large = rbLarge.IsChecked.Value;

            // Use an if / else if / else structure
            if(small == true)
            {
                txtSelection.Text = "Small Drink";
            }
            else if(medium)
            {
                txtSelection.Text = "Medium Drink";

            }
            else if(large)
            {
                txtSelection.Text = "Large Drink";
            }
            else
            {
                txtSelection.Text = "Please choose a size";

            }

            bool button1 = rbBtn1.IsChecked.Value;
            bool button2 = rb2.IsChecked.Value;

            if (button1)
            {

            }
            else if (button2)
            {

            }

        }

        private void btnDrink_Click(object sender, RoutedEventArgs e)
        {
            bool coke = rbCoke.IsChecked.Value;
            bool sprite = rbSprite.IsChecked.Value;
            bool drPepper = rbDrPepper.IsChecked.Value;

            if (coke)
            {
                txtSelection.Text = "Coke";
            }
            else if(sprite)
            {
                txtSelection.Text = "Sprite";
            }
            else if (drPepper)
            {
                txtSelection.Text = "Dr Pepper";
            }
            else
            {
                txtSelection.Text = "No Drink Was Chosen";
            }
        }

     
    }
}
