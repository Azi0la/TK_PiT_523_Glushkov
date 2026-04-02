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

namespace TK_PiT_523_Glushkov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void BTans_Click(object sender, RoutedEventArgs e)
        {
            if (RBlin.IsChecked == true) 
            {
                if (!string.IsNullOrEmpty(TBa.Text) && !string.IsNullOrEmpty(TBb.Text))
                {
                    double a;
                    double b;
                    if (Double.TryParse(TBa.Text, out a) && Double.TryParse(TBb.Text, out b))
                    {
                        double ans = Calcus_Lin(a, b);
                        TBans.Text = ans.ToString();
                    }
                    else
                    {

                        MessageBox.Show("Введено не число!");
                    }
                }
                else
                {
                    MessageBox.Show("Введены пустые значения!");
                }
            }
            if (RBsquare.IsChecked == true) 
            {
                if (!string.IsNullOrEmpty(TBa.Text) && !string.IsNullOrEmpty(TBb.Text) && !string.IsNullOrEmpty(TBc.Text))
                {
                    double a;
                    double b;
                    double c;
                    if (Double.TryParse(TBa.Text, out a) && Double.TryParse(TBb.Text, out b) && Double.TryParse(TBc.Text, out c))
                    {
                        string ans = Calcus_Square(a, b, c);
                        TBans.Text = ans;
                    }
                    else
                    {

                        MessageBox.Show("Введено не число!");
                    }
                }
                else
                {
                    MessageBox.Show("Введены пустые значения!");
                }
            }
        }

        private void RBlin_Click(object sender, RoutedEventArgs e)
        {
            LabC.Visibility = Visibility.Hidden;
            TBc.Visibility = Visibility.Hidden;
        }

        private void RBsquare_Click(object sender, RoutedEventArgs e)
        {
            LabC.Visibility = Visibility.Visible;
            TBc.Visibility = Visibility.Visible;
        }

        public double Calcus_Lin(double a, double b)
        {
            double x = (-b) / a;
            return x;
        }

        public string Calcus_Square(double a, double b, double c)
        {
            double d = Math.Pow(b, 2) - (4 * a * c);
            if(d > 0)
            {
                double x1 = ((-b) + Math.Sqrt(d)) / (2 * a);
                double x2 = ((-b) - Math.Sqrt(d)) / (2 * a);
                string ansX1 = x1.ToString();
                string ansX2 = x2.ToString();
                return ($"x1 = {ansX1}, x2 = {ansX2}");

            }
            else if(d == 0)
            {
                double x = (-b) / (2*a);
                string ansX = x.ToString();
                return ($"x = {ansX}");
            }
            else if(d < 0)
            {
                return ("Решения нет");
            }
            else
            {
                return ("Error");
            }
        }

    }
}
