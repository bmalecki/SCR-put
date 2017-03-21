using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace cw1
{
    class Program
    {
        static void testMyClass(MyClass myObj)
        {
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

        }

        static void Main(string[] args)
        {

            
            MyClass myObj = new MyClass(5000, 5500);
            testMyClass(myObj);
            
            
            Console.ReadKey();
        }
    }

}
