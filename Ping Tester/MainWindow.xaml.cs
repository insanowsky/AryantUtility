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
            int lepszyawait = 0;
            while (lepszyawait < 4)
            {
                Ping pingSender = new Ping();

                // Create a buffer of 32 bytes of data to be transmitted.
                string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
                byte[] buffer = Encoding.ASCII.GetBytes(data);

                int timeout = 3000;

                PingOptions options = new PingOptions(64, true);

                // Send the request.

                PingReply reply = pingSender.Send("1.1.1.1", timeout, buffer);

                if (reply.Status == IPStatus.Success)
                {
                    PingTarget.Text = "pinging: " + (reply.Address.ToString());
                    PingCounter.Text = (reply.RoundtripTime.ToString()) + "ms";
                  
                }
                else
                {
                    MessageBox.Show("Connection Failed");
                }
                await Task.Delay(1000);
                lepszyawait++;
                if (lepszyawait == 5)
                {
                    StopButton.Visibility = Visibility.Hidden;
                }
            }
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
    
    

    

        


