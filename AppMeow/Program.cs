using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMeow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число для функции (sin(x) - cos(x)) / 5: ");
            int x = int.Parse(Console.ReadLine());
            double F = (Math.Sin(x) - Math.Cos(x)) / 5;
            Console.WriteLine(F);
            Console.ReadKey();
            return;
        }
    }
}
