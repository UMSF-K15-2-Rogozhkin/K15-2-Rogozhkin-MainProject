using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace лаб1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сумму вклада = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите процент по вкладу = ");
            double b = double.Parse(Console.ReadLine());
            double c = a + (a * (b / 100));
            Console.WriteLine("Через год сумма на вкладе {0:c}", c);
            //Console.ReadLine();
            Console.ReadKey(); 
        }
    }
}
