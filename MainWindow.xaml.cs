﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Short_Video_Examples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Notes.RadioButton_CheckBoxes.Radio_Button_Example().Show();

        }

        private void btnRdButton_Click(object sender, RoutedEventArgs e)
        {
            new Notes.RadioButton_CheckBoxes.Radio_Button_Example().Show();
        }
    }
}