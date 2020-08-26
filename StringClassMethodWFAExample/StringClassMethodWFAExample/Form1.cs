using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringClassMethodWFAExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            string s1 = str.Substring(3, 4);
            //Taking a string
            //string str="Greeks,for Greeks";
            char[] spearator = { ',', ' ' };
            Int32 count = 3;
            //using the method
            string[] strlist = str.Split(spearator, count, StringSplitOptions.None);
            StringBuilder sb = new StringBuilder();
            foreach(string s in strlist)
            {
                sb.Append(s + "\n");
            }
            label2.Text = sb.ToString();
            string r = str.Replace('m', 'z');
            MessageBox.Show(r);
            string s5 = "Printing Backword";
            for(int i=0;i<s5.Length;i++)
            {
                System.Console.WriteLine(s5[s5.Length - i - 1]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s5 = "Printing Backword";
            for(int i=0;i<s5.Length;i++)
            {
                MessageBox.Show(s5[s5.Length - i - 1].ToString());
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string question = "HOE DOES MICROSOFT WORD DEALS WITH THE CAPS LOCK KEY ?";
            System.Text.StringBuilder sb = new System.Text.StringBuilder(question);
            for(int j=0;j<sb.Length;j++)
            {
                if (System.Char.IsLower(sb[j]) == true)
                    sb[j] = System.Char.ToUpper(sb[j]);
                else if (System.Char.IsUpper(sb[j]) == true)
                    sb[j] = System.Char.ToLower(sb[j]);
            }
            //store the new string
            string corrected = sb.ToString();
            MessageBox.Show(corrected);
        }
    }
}
