using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public MyClass(int _n1 = 10, int _n2 = 500)
        {
            n1 = _n1;
            n2 = _n2;
        }

        public void e1()
        {
            Random rnd = new Random();

            tab = new int[n2 - n1];

            for (int i = 0; i < n2 - n1; i++)
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

            for (int i = 0; i < opisaneKwadraty.Length; i++)
            {
                opisaneKwadraty[i] = Math.Pow(sortTab[i] * 2, 2);
            }

        }


        public void e4()
        {
            wpisaneKwadraty = new double[tab.Length];

            for (int i = 0; i < wpisaneKwadraty.Length; i++)
            {
                wpisaneKwadraty[i] = (2 * Math.Pow(sortTab[i], 2));
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
            for (int i = 0; i < roznica.Length; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine();
                }

                Console.Write(sortTab[i] + " " + roznica[i] + " ");


            }

            Console.WriteLine("\n");
        }
    }
}
