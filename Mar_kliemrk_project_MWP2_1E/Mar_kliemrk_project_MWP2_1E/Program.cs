using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mar_kliemrk_project_MWP2_1E
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadz wyrazy do listy!" + "\n'Wyswietl' pokaze Ci wszystkie wyrazy, ktory sa odstortowane" + "\n'Koniec' - skonczyc program");
            bool containsdigit = false;
            List<string> lista = new List<string>(); // коллекция всех значений
            string value = "";

            do
            {
                value = Console.ReadLine().ToUpper(); //считывание данных с консоли
                if (value.Length > 20) // проверка на длинну
                {
                    Console.WriteLine("Za duży wyraz!\n");
                    continue;
                }

                char[] array = value.ToCharArray(); //Записывает слова в таблицу и начинается проверка слов, которые вписали
                foreach (var item in array)
                {
                    if (Char.IsDigit(item))
                    {
                        containsdigit = true;
                        break;
                    }
                }
                if (containsdigit == true)
                {
                    containsdigit = false;
                    Console.WriteLine("Wyraz zawiera cyfry! \n");
                    continue;
                }// Проверяем есть ли в том что мы ввели цифры

                if (value == "Wyswietl") // вводим значение Wyswietl, чтобы нам показал весь посортированный список
                {
                    lista.Sort();
                    foreach (var item in lista)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (value == "Koniec")// Koniec - закрытие программы
                {
                    break;
                }
                else
                {
                    lista.Add(value); //добавление значений в коллекцию
                }

            } while (true);

        }
    }
}
