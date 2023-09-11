using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KozhevnikovDG.Sprint0.Task5.V0.Lib;

namespace Tyuiu.KozhevnikovDG.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Применение линейной структуры
            Console.WriteLine("A + B =" + DataService.Addition(5, 5));
            Console.WriteLine("A - B =" + DataService.Subtraction(10, 5));
            Console.WriteLine("A * B =" + DataService.Multiplication(10, 5));
            Console.WriteLine("A / B =" + DataService.Division(9, 3));
            Console.ReadKey();
        }
    }
}


