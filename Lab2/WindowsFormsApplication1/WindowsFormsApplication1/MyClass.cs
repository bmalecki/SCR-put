using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw1
{

    delegate void ErrorDelegate(string message);

    class MyClass
    {
        public int[] tab;
        public int[] sortTab;
        public double[] opisaneKwadraty;
        public double[] wpisaneKwadraty;
        public double[] roznica;

        private int n1, n2;

        public ErrorDelegate ed;


        public MyClass(int _n1 = 10, int _n2 = 500)
        {
            n1 = _n1;
            n2 = _n2;
        }

        public void e1()
        {

            try
            {
                Random rnd = new Random();

                tab = new int[n2 - n1];

                for (int i = 0; i < n2 - n1; i++)
                {
                    tab[i] = rnd.Next(n1, n2);
                }
            }
            catch (NullReferenceException)
            {
                ed?.Invoke("Error 1");
            }

        }

        public void e2()
        {

            try
            {

                sortTab = new int[tab.Length];

                Array.Copy(tab, sortTab, tab.Length);
                Array.Sort(sortTab);
            }
            catch (NullReferenceException)
            {
                ed?.Invoke("Error 2");
            }

        }

        public void e3()
        {
            try
            {
                opisaneKwadraty = new double[tab.Length];

                for (int i = 0; i < opisaneKwadraty.Length; i++)
                {
                    opisaneKwadraty[i] = Math.Pow(sortTab[i] * 2, 2);
                }

            }
            catch (NullReferenceException)
            {
                ed?.Invoke("Error 3");
            }



        }


        public void e4()
        {

            try
            {
              
                wpisaneKwadraty = new double[tab.Length];

                for (int i = 0; i < wpisaneKwadraty.Length; i++)
                {
                    wpisaneKwadraty[i] = (2 * Math.Pow(sortTab[i], 2));
                }

            }
            catch (NullReferenceException)
            {
                ed?.Invoke("Error 4 ");
            }

        }

        public void e5()
        {
            try
            {
                roznica = new double[sortTab.Length];
            
                for (int i = 0; i < roznica.Length; i++)
                {
                    roznica[i] = opisaneKwadraty[i] - wpisaneKwadraty[i];
                }
            }
            catch (NullReferenceException)
            {
                ed?.Invoke("Error 5");
            }
        }


        public void e6()
        {
            try
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
            catch (NullReferenceException)
            {
                ed?.Invoke("Error 6");
            }

            
        }
    }
}
