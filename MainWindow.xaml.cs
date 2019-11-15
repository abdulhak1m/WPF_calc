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

namespace wpfCalculator
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
        private void ButtonPowerOff_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        
        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            txt_num.Text = txt_num.Text + 7;
        }

        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            txt_num.Text = txt_num.Text + 4;
        }

        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            txt_num.Text = txt_num.Text + 5;
        }

        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            txt_num.Text = txt_num.Text + 6;
        }

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{

        //}

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            txt_num.Text = txt_num.Text + 1;
        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            txt_num.Text = txt_num.Text + 2;
        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            txt_num.Text = txt_num.Text + 3;
        }
        float a, b;
        int count;
        bool znak = true;
        private void btn_znak_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Div_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(txt_num.Text);
            txt_num.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            znak = true;
        }

        private void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(txt_num.Text);
            txt_num.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(txt_num.Text);
            txt_num.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(txt_num.Text);
            txt_num.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            znak = true;
        }
        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(txt_num.Text);
                    txt_num.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(txt_num.Text);
                    txt_num.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(txt_num.Text);
                    txt_num.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(txt_num.Text);
                    txt_num.Text = b.ToString();
                    break;

                default:
                    break;
            }

        }
        private void equally_Click(object sender, RoutedEventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            txt_num.Text = txt_num.Text + 0;
        }

        private void Point_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_9_Click(object sender, RoutedEventArgs e)
        {
            txt_num.Text = txt_num.Text + 9;
        }

        private void Present_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_C_Click(object sender, RoutedEventArgs e)
        {
            txt_num.Text = "";
        }

        private void btn_8_Click_1(object sender, RoutedEventArgs e)
        {
            txt_num.Text = txt_num.Text + 8;
        }
    }
}
