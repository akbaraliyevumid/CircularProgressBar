using System;
using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace Circular_ProgressBar
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

        DispatcherTimer timer = new DispatcherTimer();
        int counter = 0;

        private void timer_Tick(object sender, EventArgs e)
        {
            counter++;
            timerLabel.Text = counter.ToString();

            if (counter == 100)
            {
                timer.Stop();
                timerLabel.Text = "0".ToString();

            }
        }

        private void StartTimer()
        {
            cbp_uc.Visibility = Visibility.Visible;

            if (counter>0)
            {
                timer.Tick -= timer_Tick;
                counter = 0;
            }

            timer.Interval = TimeSpan.FromMilliseconds(188);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void StopTimer()
        {
            if (counter>0)
            {
                timer.Tick -= timer_Tick;
                counter = 0;
            }

            timer.Stop();
            cbp_uc.Visibility = Visibility.Collapsed;
            timerLabel.Text = "0".ToString();
        }

        private void StartAnimation()
        {
            ((Storyboard)cbp_uc.Resources["ProgressbarAnimation"]).Begin();
        }

        private void StopAnimation()
        {
            ((Storyboard)cbp_uc.Resources["ProgressbarAnimation"]).Stop();
        }
    }
}