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
    /// Логика взаимодействия для Zad4.xaml
    /// </summary>
    public partial class Zad4 : Window
    {
        public Zad4()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += TimerTick;
            timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            lbnowh.Content = now. ToShortTimeString();
            int NowH = now.Hour;
            int NowM = now.Minute;
            if (btn == 1)
            {
                if (h == NowH && m == NowM)
                {
                    MessageBox.Show(Vvod, "Время вышло!");
                    btn = 0;
                    this.Visibility = Visibility.Visible;
                }
            }
        }

        int h = 0;
        int m = 0;

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string name = Convert.ToString(btn.Name);
            switch (name)
            {
                case "plh":
                    if (h != 23)
                    h = h + 1;
                    else
                    {
                        h = 0;
                    }
                    break;
                case "plm":
                    if (m != 59)
                    m = m + 1;
                    else
                    {
                         m = 0;
                    }
                    break;
                case "minh":
                    if (h != 0)
                    h = h - 1;
                    if (h == 0)
                    {
                        h = 23;
                        m = 59;
                    }
                    break;
                case "minm":
                    if (m != 0)
                    m = m - 1;
                    if (m == 0)
                        m = 59;
                    break;
            }
            lbbudh.Content = h.ToString();
            lbbudm.Content = m.ToString();
        }
        int btn = 0;
        string Vvod;
        private void Okbtn_Click(object sender, RoutedEventArgs e)
        {
            
            if (h == 0 && m == 0)
            {
                MessageBox.Show("Время не установлено");
            }
            else
            {
                Vvod = vvod.Text;
                btn = 1;
                this.Visibility = Visibility.Hidden;
            }
        }
    }
}
