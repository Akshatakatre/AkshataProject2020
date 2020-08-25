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

namespace CalculationExample
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int n1, n2, res;
            n1 = Convert.ToInt32(textBox.Text);
            n2 = Convert.ToInt32(textBox1.Text);
            res = n1 + n2;
            textBox2.Text = res.ToString();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int n1, n2, res;
            n1 = Convert.ToInt32(textBox.Text);
            n2 = Convert.ToInt32(textBox1.Text);
            res = n1 - n2;
            textBox2.Text = res.ToString(); 
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int n1, n2, res;
            n1 = Convert.ToInt32(textBox.Text);
            n2 = Convert.ToInt32(textBox1.Text);
            res = n1 * n2;
            textBox2.Text = res.ToString();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int n1, n2, res;
            n1 = Convert.ToInt32(textBox.Text);
            n2 = Convert.ToInt32(textBox1.Text);
            res = n1 / n2;
            textBox2.Text = res.ToString();
        }
    }
}
