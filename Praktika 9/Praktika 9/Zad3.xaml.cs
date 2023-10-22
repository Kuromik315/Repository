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
    /// Логика взаимодействия для Zad3.xaml
    /// </summary>
    public partial class Zad3 : Window
    {
        public Zad3()
        {
            InitializeComponent();
            timer1.Interval = TimeSpan.FromSeconds(1);
            timer1.Tick += timer1_Tick;
            timer2.Interval = TimeSpan.FromSeconds(1);
            timer2.Tick += timer2_Tick;

        }
        DispatcherTimer timer1 = new DispatcherTimer();
        DispatcherTimer timer2 = new DispatcherTimer();
        int s1 = 0;
        int m1 = 20;
        int s2 = 0;
        int m2 = 20;

        private void timer1_Tick(object sender, EventArgs e)
        {
            s1 = s1 - 1;
            if (s1 < 0)
            {
                m1 = m1 - 1;
                s1 = 59;
            }
            if (s1 == 0 & m1 == 0)
            {
                timer1.Stop();
                MessageBox.Show("Время игрока 1 вышло!","Внимание");
                btn1.Visibility = Visibility.Hidden;
                
            }
            lb1.Content = m1.ToString();
            lb2.Content = s1.ToString();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            s2 = s2 - 1;
            if (s2 < 0)
            {
                m2 = m2 - 1;
                s2 = 59;
            }
            if (s2 == 0 & m2 == 0)
            {
                timer2.Stop();
                MessageBox.Show("Время игрока 2 вышло!", "Внимание");
                btn2.Visibility = Visibility.Hidden;
            }
            lb3.Content = m2.ToString();
            lb4.Content = s2.ToString();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            timer1.Start();
            timer2.Stop();
            btn1.IsEnabled = false;
            btn2.IsEnabled = true;
            a = 1;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            timer2.Start();
            timer1.Stop();
            btn1.IsEnabled = true;
            btn2.IsEnabled = false;
            a = 2;
        }

        private void Sbros_Click(object sender, RoutedEventArgs e)
        {
            lb1.Content = "20";
            lb2.Content = "0";
            lb3.Content = "20";
            lb4.Content = "0";
            btn1.IsEnabled = true;
            btn2.IsEnabled = false;
            s1 = 0;
            m1 = 20;
            s2 = 0;
            m2 = 20;
            timer1.Stop();
            timer2.Stop();
        }
        int k = 0;
        int a;
        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            if (k == 0)
            {
                timer1.Stop();
                timer2.Stop();
                btn1.IsEnabled = false;
                btn2.IsEnabled = false;
                k = 1;
            }
            else
            {
                switch (a)
                {
                    case 0:
                        btn1.IsEnabled = true;
                        break;
                    case 1: timer1.Start(); btn1.IsEnabled = false;
                        btn2.IsEnabled = true;
                        break;
                    case 2: timer2.Start(); btn1.IsEnabled = true;
                        btn2.IsEnabled = false; break;
                }
                k = 0;
            }
        }
    }
}
