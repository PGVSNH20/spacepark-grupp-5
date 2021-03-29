using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace SpaceAppWPF
{
    /// <summary>
    /// Interaction logic for ParkTimer.xaml
    /// </summary>
    public partial class ParkTimer : Page
    {
        private Stopwatch stopwatch = new Stopwatch();
        private DispatcherTimer DTimer = new DispatcherTimer();
        private string CurrentTime { get; set; }

        public ParkTimer()
        {
            InitializeComponent();
            DTimer.Tick += DTimer_Tick;
            DTimer.Interval = new TimeSpan(0, 0, 1);
        }

        //Event som körs varje sekund
        private void DTimer_Tick(object sender, EventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                TimeSpan timer = stopwatch.Elapsed;
                CurrentTime = timer.Seconds.ToString();
                Timer1Text.Content = CurrentTime;
            }
        }

        private void TimerStop(object sender, RoutedEventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                stopwatch.Stop();
            }
            listBox.Items.Add(CurrentTime);
        }

        private void TimerStart(object sender, RoutedEventArgs e)
        {
            Timer1Text.Visibility = Visibility.Visible;
            stopwatch.Start();
            DTimer.Start();
        }

        private void TimerReset(object sender, RoutedEventArgs e)
        {
            stopwatch.Reset();
            Timer1Text.Content = "0";
        }
    }
}