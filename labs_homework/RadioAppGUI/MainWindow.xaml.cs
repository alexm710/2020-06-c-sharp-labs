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
using System.Windows.Navigation;
using System.Windows.Shapes;
using RadioApp;

namespace RadioAppGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Radio radio = new Radio();
        static string channel = "";
        public MainWindow()
        {
            InitializeComponent();

        }

        // Radio Buttons 1 - 4 //
        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            radio.Channel = 1;
            channel = radio.Play();
            LabelDisplay.Content = radio.Play();
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            radio.Channel = 2;
            channel = radio.Play();
            LabelDisplay.Content = radio.Play();
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            radio.Channel = 3;
            channel = radio.Play();
            LabelDisplay.Content = radio.Play();
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            radio.Channel = 4;
            channel = radio.Play();
            LabelDisplay.Content = radio.Play();
        }

        // Radio Channel Up & Down

        private void BtnChanUp_Click(object sender, RoutedEventArgs e)
        {
            radio.Channel += 1;
            channel = radio.Play();
            LabelDisplay.Content = radio.Play();
            if (radio.Channel > 4)
            {
                LabelDisplay.Content = "There are only 4 channels";
            }
        }
        

        private void BtnChanDown_Click(object sender, RoutedEventArgs e)
        {
            radio.Channel -= 1;
            channel = radio.Play();
            LabelDisplay.Content = radio.Play();
        }

        private void BtnPowerOn_Click(object sender, RoutedEventArgs e)
        {
            radio.TurnOn();
            LabelDisplay.Content = radio.Play();
        }

        private void BtnPowerOff_Click(object sender, RoutedEventArgs e)
        {
            radio.TurnOff();
            LabelDisplay.Content = radio.Play();
        }

        private void BtnVolUp_Click(object sender, RoutedEventArgs e)
        {
            radio.IncreaseVolume();
            LabelDisplay.Content = radio.IncreaseVolume();
        }

        private void BtnVolDown_Click(object sender, RoutedEventArgs e)
        {
            radio.DecreaseVolume();
            LabelDisplay.Content = radio.DecreaseVolume();
        }

        private void BtnPlay_Click(object sender, RoutedEventArgs e)
        {
            radio.Play();
            LabelDisplay.Content = radio.Play();
        }
    }
}