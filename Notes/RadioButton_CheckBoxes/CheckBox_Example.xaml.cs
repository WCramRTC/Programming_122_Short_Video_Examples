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
    /// Interaction logic for CheckBox_Example.xaml
    /// </summary>
    public partial class CheckBox_Example : Window
    {
        public CheckBox_Example()
        {
            InitializeComponent();
        }

        private void btnDisplayOptions_Click(object sender, RoutedEventArgs e)
        {
            // Check boxes always return true or false
            // In order to get the check box result, you use name.IsChecked.Value
            bool pepperoni = ckPepperoni.IsChecked.Value;
            bool olives = ckOlives.IsChecked.Value;
            bool cheese = ckCheese.IsChecked.Value;
            bool pineapple = ckPineapple.IsChecked.Value;

            bool checkBox = ckCheckBox.IsChecked.Value;

            // Clearing the Rich Text Box First
            runDisplay.Text = "";

            // Condition
            if(pepperoni == true)
            {
                runDisplay.Text += "Pepperoni\n";
            }

            if(olives)
            {
                runDisplay.Text += "Olives\n";
            }

            if(cheese)
            {
                runDisplay.Text += "Cheese\n";

            }

            if (pineapple)
            {
                runDisplay.Text += "Pineapple\n";

            }

        }


        private void ckIsSelected_Checked(object sender, RoutedEventArgs e)
        {
            bool isChecked = ckIsSelected.IsChecked.Value;
            string display = "Is Checked: " + isChecked;

            lblIsSelected.Content = display;

        }

    }
}
