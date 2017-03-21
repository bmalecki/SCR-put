using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cw1;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private MyClass obj;

        private void errorMsg(string msg)
        {
            MessageBox.Show(msg);
        }

        public Form1()
        {
            InitializeComponent();

            obj = new MyClass(25, 1000);
            obj.ed = errorMsg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj.e1();
            chart1.Series[0].Points.Clear();
            richTextBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            obj.e2();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            obj.e5();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string temp = "";

            var points = chart1.Series[0].Points;

            for (int i = 0; i < obj.tab.Length; i++)
            {
                if (i % 5 == 0)
                {
                    temp += "\n";
                }
                temp += String.Format("{0}\t{1}\t", obj.sortTab[i], obj.roznica[i]);       
            }

            chart1.Series[0].Points.DataBindXY(obj.sortTab, obj.roznica);
            richTextBox1.Text = temp;
            obj.e6();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            obj.e3();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            obj.e4();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
