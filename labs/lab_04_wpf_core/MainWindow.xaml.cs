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

namespace lab_04_wpf_core
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
        public partial class MainWindow : Window
        {

            long number1 = 0;
            long number2 = 0;
            string operation = "";


            public MainWindow()
            {
                InitializeComponent();
            }

            private void btn1_Click(object sender, RoutedEventArgs e)
            {
                if (operation == "")
                {
                    number1 = (number1 * 10) + 1;
                    txtDisplay.Text = number1.ToString();
                }
                else
                {
                    number2 = (number2 * 10) + 1;
                    txtDisplay.Text = number2.ToString();
                }
            }

            private void buttotn2_Click(object sender, RoutedEventArgs e)
            {
                if (operation == "")
                {
                    number1 = (number1 * 10) + 2;
                    txtDisplay.Text = number1.ToString();
                }
                else
                {
                    number2 = (number2 * 10) + 2;
                    txtDisplay.Text = number2.ToString();
                }
            }

            private void btn3_Click(object sender, RoutedEventArgs e)
            {
                if (operation == "")
                {
                    number1 = (number1 * 10) + 3;
                    txtDisplay.Text = number1.ToString();
                }
                else
                {
                    number2 = (number2 * 10) + 3;
                    txtDisplay.Text = number2.ToString();
                }
            }

            private void btn4_Click(object sender, RoutedEventArgs e)
            {
                if (operation == "")
                {
                    number1 = (number1 * 10) + 4;
                    txtDisplay.Text = number1.ToString();
                }
                else
                {
                    number2 = (number2 * 10) + 4;
                    txtDisplay.Text = number2.ToString();
                }
            }

            private void btn5_Click(object sender, RoutedEventArgs e)
            {
                if (operation == "")
                {
                    number1 = (number1 * 10) + 5;
                    txtDisplay.Text = number1.ToString();
                }
                else
                {
                    number2 = (number2 * 10) + 5;
                    txtDisplay.Text = number2.ToString();
                }
            }

            private void btn6_Click(object sender, RoutedEventArgs e)
            {
                if (operation == "")
                {
                    number1 = (number1 * 10) + 6;
                    txtDisplay.Text = number1.ToString();
                }
                else
                {
                    number2 = (number2 * 10) + 6;
                    txtDisplay.Text = number2.ToString();
                }
            }

            private void btn7_Click(object sender, RoutedEventArgs e)
            {
                if (operation == "")
                {
                    number1 = (number1 * 10) + 7;
                    txtDisplay.Text = number1.ToString();
                }
                else
                {
                    number2 = (number2 * 10) + 7;
                    txtDisplay.Text = number2.ToString();
                }
            }

            private void btn8_Click(object sender, RoutedEventArgs e)
            {
                if (operation == "")
                {
                    number1 = (number1 * 10) + 8;
                    txtDisplay.Text = number1.ToString();
                }
                else
                {
                    number2 = (number2 * 10) + 8;
                    txtDisplay.Text = number2.ToString();
                }
            }

            private void btn9_Click(object sender, RoutedEventArgs e)
            {
                if (operation == "")
                {
                    number1 = (number1 * 10) + 9;
                    txtDisplay.Text = number1.ToString();
                }
                else
                {
                    number2 = (number2 * 10) + 9;
                    txtDisplay.Text = number2.ToString();
                }
            }
        }
}