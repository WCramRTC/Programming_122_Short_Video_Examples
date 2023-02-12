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

namespace Short_Video_Examples.Notes.Time_Objects_And_Pickers
{
    /// <summary>
    /// Interaction logic for DateTimeExamples.xaml
    /// </summary>
    public partial class DateTimeExamples : Window
    {
        public DateTime timeFromPickerStart;
        public DateTime timeFromPickerEnd;
        public DateTime timeFromCalander;


        public DateTimeExamples()
        {
            InitializeComponent();
        } 

        public void DateTimeExamplesGiven()
        {
            timeFromPickerStart = dtpStart.SelectedDate.Value;
            timeFromPickerEnd = dtpEnd.SelectedDate.Value;

        }

        public void DisplayDates()
        {
            runDisplayTimes.Text = "";

            bool hasDate = calDate.SelectedDate.HasValue;

            if(!hasDate)
            {
                timeFromCalander = DateTime.Now;
                
            }
            else
            {
                timeFromCalander = calDate.SelectedDate.Value;
            }

   
            // Display Long Date
            runDisplayTimes.Text += timeFromCalander.ToLongDateString();
            runDisplayTimes.Text += "\n";

            // DIsplay Short Date
            runDisplayTimes.Text += timeFromCalander.ToShortDateString();
            runDisplayTimes.Text += "\n";

            // Display Long Time
            runDisplayTimes.Text += timeFromCalander.ToLongTimeString();
            runDisplayTimes.Text += "\n";

            // Display Short Time
            runDisplayTimes.Text += timeFromCalander.ToShortTimeString();
            runDisplayTimes.Text += "\n";

            // Display The Current Time
            runDisplayTimes.Text += timeFromCalander.TimeOfDay.ToString();
            runDisplayTimes.Text += "\n";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DisplayDates();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(dtpStart.SelectedDate.HasValue)
            {
                timeFromPickerStart = dtpStart.SelectedDate.Value;
            } 
            else
            {
                timeFromPickerStart = DateTime.Now;
            }

            if (dtpEnd.SelectedDate.HasValue)
            {
                timeFromPickerEnd = dtpEnd.SelectedDate.Value;
            }
            else
            {
                timeFromPickerEnd = DateTime.Now;
            }

            TimeSpan different = timeFromPickerEnd - timeFromPickerStart;

            runDisplayTimeDifference.Text = (different.Days / 365.25).ToString();

        }
    }
}
