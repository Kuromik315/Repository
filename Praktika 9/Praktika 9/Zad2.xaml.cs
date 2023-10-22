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
    /// Логика взаимодействия для Zad2.xaml
    /// </summary>
    public partial class Zad2 : Window
    {
        public Zad2()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
        }
        DispatcherTimer timer = new DispatcherTimer();
        int k = 0;

        private void Timer_Tick(object sender, EventArgs e)
        {
            s = s - 1;
            if (s < 0)
            {
                s = 59;
                m = m - 1;
            }
            if (m == -1)
            {
                h = h - 1;
                m = 59;
            }
            if (h == 0 && m== 0 && s == 0)
            {
                timer.Stop();
                MessageBox.Show("Время вышло!", "БууУУуум!!!");
            }
            label1.Content = Convert.ToString(h);
            label3.Content = Convert.ToString(m);
            label5.Content = Convert.ToString(s);
        }

        int h;
        int m;
        int s;
        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            if (k == 0)
            {
                h = Convert.ToInt32(textBox1.Text);
                m = Convert.ToInt32(textBox2.Text);
                s = Convert.ToInt32(textBox3.Text);
                timer.Start();
            }
            else
            {
                timer.Start();
                k = 0;
            }
        }

        private void StopBtn_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            k = 1;
        }

        private void ResetBtn_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            label1.Content = "0";
            label3.Content = "0";
            label5.Content = "0";
        }
    }
}
