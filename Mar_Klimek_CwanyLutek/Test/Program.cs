using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ile chesz porownac?");
            long a = long.Parse(Console.ReadLine()); // Сколько будет сравнивать
            while (a != 0) // Петля, которая каждый раз будет отбавлять от значения a еденицу. После вычисления одной пары, уже будет до 0
            {
                long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse); // Генерация таблицы, в которую записываем числа через пробел

                if (numbers[1] == numbers[0]){ // Символ Ньютона. C = n | k = n!/(k!*(n-k)!). Если число n будет равно числу k, то будет число нечётное, а если два числа не будут равны друг другу, то тогда число чётное. n == k => 1, n != k => чётное.

                    Console.WriteLine("Nieparzyste"); // Если нечётное число то пишет 
                }
                else 
                {
                    Console.WriteLine("Parzyste"); // Если чётное число 
                }
                a--; // Уменьшается на один 
            }
            Console.ReadKey();
        }
    }
}