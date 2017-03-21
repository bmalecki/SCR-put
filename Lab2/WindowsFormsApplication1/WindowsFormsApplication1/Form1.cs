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
using System.Threading;

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

            obj = new MyClass(25, 10000);
            obj.ed = errorMsg;
           /* backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;*/
            backgroundWorker1.WorkerReportsProgress = true;
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

            for (int i = 0; i < obj.tab.Length; i++)
            {
                if (i % 5 == 0)
                {
                    temp += "\n";
                }
                temp += String.Format("{0}\t{1}\t", obj.sortTab[i], obj.roznica[i]);

            }
            //backgroundWorker1.RunWorkerAsync();
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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < obj.tab.Length; i++)
            {
                Thread.Sleep(100);            

                backgroundWorker1.ReportProgress(i/ obj.tab.Length, new WorkerArgument
                {
                   
                });
            }
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
          
        }

        public class WorkerArgument
        {
            public double X { get; set; }
            public double Y { get; set; }
        }
    }
}
