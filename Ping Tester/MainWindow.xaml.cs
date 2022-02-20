using System;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

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
                Ping pingSender = new();

                // tworzy 32 bitowy stos danych do wyslania
                string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
                byte[] buffer = Encoding.ASCII.GetBytes(data);

                int timeout = 1000;

                PingOptions options = new(64, true);

                // wysyla pinga
                var ipcloudflare = "1.1.1.1";
                var ipgoogle = "8.8.8.8";
                var ipgoogle2 = "8.8.4.4";
                Random losoweip = new();
                var zmienneip = new[] { ipgoogle, ipcloudflare, ipgoogle2 };

                PingReply reply = pingSender.Send(zmienneip[losoweip.Next(zmienneip.Length)], timeout, buffer);
                if (reply.Status == IPStatus.Success)
                {

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

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Close();
        }

        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sorry but this app is not optimized for maximizing yet :(");

            //tba after optimizing for full screen
            //if (Application.Current.MainWindow.WindowState != WindowState.Maximized)
            //{
            // Application.Current.MainWindow.WindowState = WindowState.Maximized;
            //} else
            //{
            //  Application.Current.MainWindow.WindowState = WindowState.Normal;
            //}
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

    }
}