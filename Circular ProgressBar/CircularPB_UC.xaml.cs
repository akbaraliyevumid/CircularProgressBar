using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Circular_ProgressBar
{
    /// <summary>
    /// Interaction logic for CircularPB_UC.xaml
    /// </summary>
    public partial class CircularPB_UC : UserControl
    {
        public CircularPB_UC()
        {
            InitializeComponent();
        }

        private void Storyboard_Completed(object sender, EventArgs e)
        {
            if (Application.Current.MainWindow is MainWindow mainWindow)
            {
                mainWindow.startBtn.IsChecked = false;
            }
        }
    }
}