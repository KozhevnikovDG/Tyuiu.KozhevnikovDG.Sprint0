using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KozhevnikovDG.Sprint0.Task4.V0.Lib;

namespace Tyuiu.KozhevnikovDG.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пример линейной структуры 
            Console.WriteLine(DataService.Addition(1, 5));

            Console.WriteLine(DataService.Subtraction(15, 5));

            Console.WriteLine(DataService.Multiplication(24, 45));

            Console.WriteLine(DataService.Division(14, 7));

            Console.ReadKey();
        }
    }
}
