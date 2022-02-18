using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Diagnostics;
using System.Net.NetworkInformation;

namespace Ping_Tester
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void StartButton_Click(object sender, RoutedEventArgs e)
        {
            StopButton.Visibility = Visibility.Visible;
            PingCountdown.Visibility = Visibility.Visible;
            int lepszyawait = 10;
            while (lepszyawait >= 1)
            {
                Ping pingSender = new Ping();

                // tworzy 32 bitowy stos danych do wyslania
                string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
                byte[] buffer = Encoding.ASCII.GetBytes(data);

                int timeout = 3000;

                PingOptions options = new PingOptions(64, true);

                // wysyla pinga
                var ipgoogle = "1.1.1.1";
                var ipcloudflare = "8.8.8.8";
                Random losoweip = new Random();
                var zmienneip = new[] {ipgoogle, ipcloudflare};

                PingReply reply = pingSender.Send(zmienneip[losoweip.Next(zmienneip.Length)], timeout, buffer);
                if (reply.Status == IPStatus.Success) { 

                    PingTarget.Text = "pinging: " + (reply.Address.ToString());
                    PingCounter.Text = (reply.RoundtripTime.ToString()) + "ms";
                    PingCountdown.Text = "Time left: " + lepszyawait.ToString();

                }
                else
                {
                    PingCounter.Text = "Failed to ping " + (reply.Address.ToString());
                }
                await Task.Delay(1000);
                lepszyawait--;
                if (lepszyawait < 1)
                {
                    StopButton.Visibility = Visibility.Hidden;
                    PingCountdown.Text = "Test Finished";
                }
            }
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
    
    

    

        


