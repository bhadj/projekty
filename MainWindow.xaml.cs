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

namespace projektick
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int boost = 0;
        double cenaBoost = 0;
        bool miecz1 = false;
        bool miecz2 = false;
        bool miecz3 = false;
        bool miecz4 = false;
        bool miecz1Wypo = false;
        bool miecz2Wypo = false;
        bool miecz3Wypo = false;
        bool miecz4Wypo = false;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void startuj(object sender, RoutedEventArgs e)
        {
            miecz1 = false;
            miecz2 = false;
            miecz3 = false;
            miecz4 = false;
            miecz1Wypo = false;
            miecz2Wypo = false;
            miecz3Wypo = false;
            miecz4Wypo = false;
            boost = 0;
            hajsik.Text = "0";
            start.Visibility = Visibility.Collapsed;
            gra.Visibility = Visibility.Visible;
        }
        private void resetuj(object sender, RoutedEventArgs e)
        {
            start.Visibility = Visibility.Collapsed;
            gra.Visibility = Visibility.Visible;
        }
        private void koniec(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void sklepik(object sender, RoutedEventArgs e)
        {
            gra.Visibility = Visibility.Collapsed;
            sklep.Visibility = Visibility.Visible;
        }
        private void kupMiecz1(object sender, RoutedEventArgs e)
        {
            double korony = Int32.Parse(hajsik.Text);
            if(korony >= 1000)
            {
                MessageBox.Show("Ulepszony miecz szkoły Wilka został zakupiony");
                miecz1 = true;
                korony -= 1000;
                hajsik.Text = korony.ToString();
            }
            else
            {
                MessageBox.Show("Nie masz tylu koron. Potrzebujesz mieć ich 1000");
            }
        }
        private void kupMiecz2(object sender, RoutedEventArgs e)
        {
            double korony = Int32.Parse(hajsik.Text);
            if (korony >= 5000)
            {
                MessageBox.Show("Wyśmienity miecz szkoły Wilka został zakupiony");
                miecz2 = true;
                korony -= 5000;
                hajsik.Text = korony.ToString();
            }
            else
            {
                MessageBox.Show("Nie masz tylu koron. Potrzebujesz mieć ich 5000");
            }
        }
        private void kupMiecz3(object sender, RoutedEventArgs e)
        {
            double korony = Int32.Parse(hajsik.Text);
            if (korony >= 25000)
            {
                MessageBox.Show("Mistrzowski miecz szkoły Wilka został zakupiony");
                miecz3 = true;
                korony -= 25000;
                hajsik.Text = korony.ToString();
            }
            else
            {
                MessageBox.Show("Nie masz tylu koron. Potrzebujesz mieć ich 25000");
            }
        }
        private void kupMiecz4(object sender, RoutedEventArgs e)
        {
            double korony = Int32.Parse(hajsik.Text);
            if (korony >= 75000)
            {
                MessageBox.Show("Arcymistrzowski miecz szkoły Wilka został zakupiony");
                miecz4 = true;
                korony -= 75000;
                hajsik.Text = korony.ToString();
            }
            else
            {
                MessageBox.Show("Nie masz tylu koron. Potrzebujesz mieć ich 75000");
            }
        }
        private void kupBoost(object sender, RoutedEventArgs e)
        {
            double korony = Int32.Parse(hajsik.Text);
            if(boost == 0)
            {
                cenaBoost = 50;
                boosty.Content = cenaBoost.ToString() + " koron";
            }
            else if(boost >= 1)
            {
                cenaBoost = 50 * boost * 1.2;
                boosty.Content = cenaBoost.ToString() + " koron";
            }
            if(korony >= cenaBoost)
            {
                korony -= cenaBoost;
                boost += 1;
                hajsik.Text = korony.ToString();
                
            }
            else if(korony < cenaBoost)
            {
                MessageBox.Show("Nie masz tylu koron. Potrzebujesz ich " + cenaBoost);
            }
        }
        private void koniecZakupow(object sender, RoutedEventArgs e)
        {
            sklep.Visibility = Visibility.Collapsed;
            gra.Visibility = Visibility.Visible;
        }
        private void MainMenu(object sender, RoutedEventArgs e)
        {
            gra.Visibility = Visibility.Collapsed;
            start.Visibility = Visibility.Visible;
        }
        private void geralt(object sender, RoutedEventArgs e)
        {
            double hajs = Int32.Parse(hajsik.Text);
            if(boost == 0)
            {
                if (miecz1Wypo == false && miecz2Wypo == false && miecz3Wypo == false && miecz4Wypo == false)
                {
                    hajs += 50;
                    hajsik.Text = hajs.ToString();
                }
                else if (miecz1Wypo == true && miecz2Wypo == false && miecz3Wypo == false && miecz4Wypo == false)
                {
                    hajs += 100;
                    hajsik.Text = hajs.ToString();
                }
                else if (miecz2Wypo == true && miecz1Wypo == false && miecz3Wypo == false && miecz4Wypo == false)
                {
                    hajs += 500;
                    hajsik.Text = hajs.ToString();
                }
                else if (miecz3Wypo == true && miecz2Wypo == false && miecz1Wypo == false && miecz4Wypo == false)
                {
                    hajs += 2500;
                    hajsik.Text = hajs.ToString();
                }
                else if (miecz4Wypo == true && miecz2Wypo == false && miecz3Wypo == false && miecz1Wypo == false)
                {
                    hajs += 7500;
                    hajsik.Text = hajs.ToString();
                }
            }
            else if(boost >= 1)
            {
                if (miecz1Wypo == false && miecz2Wypo == false && miecz3Wypo == false && miecz4Wypo == false)
                {
                    hajs += 50 * (boost * 1.1);
                    hajsik.Text = hajs.ToString();
                }
                else if (miecz1Wypo == true && miecz2Wypo == false && miecz3Wypo == false && miecz4Wypo == false)
                {
                    hajs += 100 * (boost * 1.1);
                    hajsik.Text = hajs.ToString();
                }
                else if (miecz2Wypo == true && miecz1Wypo == false && miecz3Wypo == false && miecz4Wypo == false)
                {
                    hajs += 500 * (boost * 1.1);
                    hajsik.Text = hajs.ToString();
                }
                else if (miecz3Wypo == true && miecz2Wypo == false && miecz1Wypo == false && miecz4Wypo == false)
                {
                    hajs += 2500 * (boost * 1.1);
                    hajsik.Text = hajs.ToString();
                }
                else if (miecz4Wypo == true && miecz2Wypo == false && miecz3Wypo == false && miecz1Wypo == false)
                {
                    hajs += 7500 * (boost * 1.1);
                    hajsik.Text = hajs.ToString();
                }
            }
        }
        private void eq(object sender, RoutedEventArgs e)
        {
            gra.Visibility = Visibility.Collapsed;
            eku.Visibility = Visibility.Visible;
            if(boost >= 1)
            {
                booster1.Text = "Masz " + boost.ToString() + " boosterów";
                booster2.Text = "+" + (boost*10).ToString() + "% koron/klik";
            }
        }
        private void wezMiecz1(object sender, RoutedEventArgs e)
        {
            if(miecz1 == true)
            {
                miecz1Wypo = true;
                miecz2Wypo = false;
                miecz3Wypo = false;
                miecz4Wypo = false;
                MessageBox.Show("Wyposażyłeś Ulepszony miecz szkoły Wilka");
            }
            else if(miecz1Wypo == true)
            {
                MessageBox.Show("Ten miecz jest już wyposażony");
            }
            else if(miecz1 == false)
            {
                MessageBox.Show("Nie posiadasz tego miecza");
            }
        }
        private void wezMiecz2(object sender, RoutedEventArgs e)
        {
            if (miecz2 == true)
            {
                miecz2Wypo = true;
                miecz1Wypo = false;
                miecz3Wypo = false;
                miecz4Wypo = false;
                MessageBox.Show("Wyposażyłeś Wyśmienity miecz szkoły Wilka");
            }
            else if (miecz2Wypo == true)
            {
                MessageBox.Show("Ten miecz jest już wyposażony");
            }
            else if (miecz2 == false)
            {
                MessageBox.Show("Nie posiadasz tego miecza");
            }
        }
        private void wezMiecz3(object sender, RoutedEventArgs e)
        {
            if (miecz3 == true)
            {
                miecz3Wypo = true;
                miecz2Wypo = false;
                miecz1Wypo = false;
                miecz4Wypo = false;
                MessageBox.Show("Wyposażyłeś Mistrzowski miecz szkoły Wilka");
            }
            else if (miecz3Wypo == true)
            {
                MessageBox.Show("Ten miecz jest już wyposażony");
            }
            else if (miecz3 == false)
            {
                MessageBox.Show("Nie posiadasz tego miecza");
            }
        }
        private void wezMiecz4(object sender, RoutedEventArgs e)
        {
            if (miecz4 == true)
            {
                miecz4Wypo = true;
                miecz2Wypo = false;
                miecz3Wypo = false;
                miecz1Wypo = false;
                MessageBox.Show("Wyposażyłeś Arcymistrzowski miecz szkoły Wilka");
            }
            else if (miecz4Wypo == true)
            {
                MessageBox.Show("Ten miecz jest już wyposażony");
            }
            else if (miecz4 == false)
            {
                MessageBox.Show("Nie posiadasz tego miecza");
            }
        }
        private void koniecEq(object sender, RoutedEventArgs e)
        {
            eku.Visibility = Visibility.Collapsed;
            gra.Visibility = Visibility.Visible;
        }
    }
}
