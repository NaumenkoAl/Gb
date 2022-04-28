using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Solution
    {
        static void Main(string[] args)
        {
            DateTime myDate = DateTime.Now;
            Console.WriteLine("Введите Ваше Имя: ");
            string inputName = Console.ReadLine();  
            Console.WriteLine($"Привет, {inputName}, сегодня {myDate}");
            Console.ReadLine();
        }
    }
}
