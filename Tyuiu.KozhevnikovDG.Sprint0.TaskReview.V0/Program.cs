using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KozhevnikovDG.Sprint0.TaskReview.V0.Lid;

namespace Tyuiu.KozhevnikovDG.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstInt = 1;
            int SecondInt = 2;
            int ThirdInt = 3;

            int res = DataService.Calc(FirstInt, SecondInt, ThirdInt);

            Console.WriteLine("Произведение суммы чисел " + FirstInt + ", " + SecondInt + " и " + ThirdInt + " на 5 равняется " + res);
            Console.ReadKey();
        }
    }
}
