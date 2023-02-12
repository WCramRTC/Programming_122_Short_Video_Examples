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

namespace Short_Video_Examples.Notes.Rich_Text_Box
{
    /// <summary>
    /// Interaction logic for Rich_Text_Box_Advanced.xaml
    /// </summary>
    public partial class Rich_Text_Box_Advanced : Window
    {
        FlowDocument document = new FlowDocument();

        public Rich_Text_Box_Advanced()
        {
            InitializeComponent();
            rtbDisplay.Document = document;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string headerText = txtHeader.Text;
            string body = runBodyText.Text;

            Paragraph paragraph = new Paragraph();
            Run inline = new Run();

            Run header = new Run();
            header.Text = headerText;
            header.FontWeight = FontWeights.Bold;
            header.FontSize = 32;
            header.Foreground = new SolidColorBrush(Color.FromRgb(255, 55, 55));

            inline.Text = body;

            paragraph.Inlines.Add(header);
            paragraph.Inlines.Add(NewLine());
            paragraph.Inlines.Add(inline);

            document.Blocks.Add(paragraph);

        }

        private Run NewLine()
        {
            return new Run("\n\n");
        }
    }
}
