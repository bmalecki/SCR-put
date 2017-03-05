using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace cw1
{
    class MyClass
    {
        public int[] tab;
        public int[] sortTab;
        public double[] opisaneKwadraty;
        public double[] wpisaneKwadraty;
        public double[] roznica;

        private int n1, n2;


        public MyClass(int _n1 = 10 , int _n2 = 500)
        {
            n1 = _n1;
            n2 = _n2;
        }

        public void e1()
        {
            Random rnd = new Random();

            tab = new int[n2 - n1];
            
            for(int i = 0; i < n2 - n1; i++)
            {
                tab[i] = rnd.Next(n1, n2);
            }

        }

        public void e2()
        {
            sortTab = new int[tab.Length];

            Array.Copy(tab, sortTab, tab.Length);
            Array.Sort(sortTab);           
        }

        public void e3()
        {
            opisaneKwadraty = new double[tab.Length];

            for(int i = 0; i < opisaneKwadraty.Length ; i++)
            {
                opisaneKwadraty[i] = Math.Pow(sortTab[i] * 2, 2);
            }          

        }


        public void e4()
        {
            wpisaneKwadraty = new double[tab.Length];

            for (int i = 0; i < wpisaneKwadraty.Length; i++)
            {
                wpisaneKwadraty[i] =  (2 * Math.Pow(sortTab[i], 2)) ;
            }

        }

        public void e5()
        {
            roznica = new double[tab.Length];        

            for (int i = 0; i < roznica.Length; i++)
            {
                roznica[i] = opisaneKwadraty[i] - wpisaneKwadraty[i];
            }
        }


        public void e6()
        {


        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            MyClass myObj = new MyClass(10, 200000);

            Stopwatch stopWatch = new Stopwatch();
            

            stopWatch.Start();
            myObj.e1();
            stopWatch.Stop();
            Console.WriteLine("E1: " + stopWatch.ElapsedMilliseconds + "\n");


            stopWatch.Restart();
            myObj.e2();
            stopWatch.Stop();
            Console.WriteLine("E2: " + stopWatch.ElapsedMilliseconds + "\n");



            stopWatch.Restart();
            myObj.e3();
            stopWatch.Stop();
            Console.WriteLine("E3: " + stopWatch.ElapsedMilliseconds + "\n");


            stopWatch.Restart();
            myObj.e4();
            stopWatch.Stop();
            Console.WriteLine("E4: " + stopWatch.ElapsedMilliseconds + "\n");



            stopWatch.Restart();
            myObj.e5();
            stopWatch.Stop();
            Console.WriteLine("E5: " + stopWatch.ElapsedMilliseconds + "\n");



            stopWatch.Restart();
            myObj.e6();
            stopWatch.Stop();
            Console.WriteLine("E6: " + stopWatch.ElapsedMilliseconds + "\n");



            Console.ReadKey();
        }
    }

}
