//Ошибка: Вывод 2 слов подряд
using System;
using System.Collections.Generic;
namespace _8_III_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введитие строку: ");
            string s = Console.ReadLine();
            string[] writes = s.Split();

            Console.Write("Введите число повторений: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < writes.Length; i++)
            {
                string write = writes[i];

                int count = 0;
                foreach (string words in writes)
                {
                    if (words == write)
                        count++;
                }
                if (count >= n) {
                        Console.WriteLine(writes[i]);
                }
                    
            }
        }
    }
}
