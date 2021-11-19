using System;
using System.Linq;

namespace pr_32_prakt17_1_OAP_ZhuravlevTimofeyVasilievich
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] k = Enumerable.Range(0, 10).Select(i =>
            {
                Console.Write($"k[{i}] = ");
                return double.Parse(Console.ReadLine());
            }).ToArray();
            double sum = k.Sum();
            Console.WriteLine($"Сумма чисел = {sum}");
            Console.ReadKey();
        }
    }
}
