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
using System.Windows.Threading;

namespace Crasher
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(500)
            };
            timer.Tick += (s, e) =>
            {
                System.Diagnostics.Debug.WriteLine($"title is {this.Title} Active is {this.IsActive}");
            };
            KeyDown += (s, e) =>
            {
                System.Diagnostics.Debug.WriteLine($"Key pressed");
            };
            timer.Start();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int b = 0;
            int a = 1/b;
        }
    }
}
