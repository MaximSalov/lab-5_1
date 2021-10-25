using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 7 чисел");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());
            int f = Convert.ToInt32(Console.ReadLine());
            int g = Convert.ToInt32(Console.ReadLine());
            int[] j = new int [] {a, b, c, d, e, f, g};
            float S = 0;
            for (int i=0;i<7;i++)
            {
                S+=j [i];
            }
            Console.WriteLine("Среднее арифметическое значение {0,4:f2}",S/7);
            Console.ReadKey();
        }
    }
}
