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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Praktika_9
{
    /// <summary>
    /// Логика взаимодействия для Zad1.xaml
    /// </summary>
    public partial class Zad1 : Window
    {
        public Zad1()
        {
            InitializeComponent();
           
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        DispatcherTimer timer = new DispatcherTimer();

        void Timer_Tick(object sender, EventArgs e)
        {
            iblTime.Content = DateTime.Now.ToLongTimeString();
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            timer.IsEnabled = true;
            timer.Start();
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            timer.IsEnabled = false;
            timer.Stop();
        }
    }
}
