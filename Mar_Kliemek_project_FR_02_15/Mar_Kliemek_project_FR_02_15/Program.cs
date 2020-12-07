using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mar_Kliemek_project_FR_02_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ilosc testow:");
            int num = 0; 
            try
            {
            num = Convert.ToInt32(Console.ReadLine()); // Кол-во тестов
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                Console.WriteLine("Sproboj ponownie");
            }

            string[][] zm = new string[num][];  // создание зубчатого массива в котором будут находится значения чисел
            for (int i = 0; i < num; i++)
            {
                try
                {
                 zm[i] = Console.ReadLine().Split(' '); // odczyt строки и разбитие ее на числа в массив
                }
                catch (Exception error1)
                {
                    Console.WriteLine(error1.Message);
                    Console.WriteLine("Sproboj ponownie");
                }
                
            }

            for (int i = 0; i < num; i++)
            {
                try
                {
                ulong num1 = Convert.ToUInt64(zm[i][0]); // конвертация
                ulong num2 = Convert.ToUInt64(zm[i][1]);
                Console.WriteLine(num1 + num2); // сложение
                }
                catch (Exception error2)
                {
                    Console.WriteLine(error2.Message);
                }
            }
            Console.ReadKey();        
        }     
    }
}
