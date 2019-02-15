using System;

namespace PrintAllDigitsOfNumber
{
    class Program
    {
        /* ПЕРВЫЙ ВАРИАНТ ЧЕРЕЗ РЕКУРСИВНУЮ ФУНКЦИЮ */
        static void PrintDigits(int value)
        {
            if (value >= 10)
            {
                PrintDigits(value / 10);
            }
            Console.Write("{0},", value % 10);
        }
        /* ПЕРВЫЙ ВАРИАНТ ЧЕРЕЗ РЕКУРСИВНУЮ ФУНКЦИЮ */
        static void Main(string[] args)
        {
            int number;
            Console.Write("Number: ");
            number = Convert.ToInt32(Console.ReadLine());
            
            /* ПЕРВЫЙ ВАРИАНТ ЧЕРЕЗ РЕКУРСИВНУЮ ФУНКЦИЮ */
            PrintDigits(number);
            /* ПЕРВЫЙ ВАРИАНТ ЧЕРЕЗ РЕКУРСИВНУЮ ФУНКЦИЮ */

            /* ВТОРОЙ ВАРИАНТ ЧЕРЕЗ ЦИКЛ*/
            Console.WriteLine();
            string resultString = "";
            while (number > 0)
            {
                resultString = Convert.ToString(number % 10) + "," + resultString;
                number = number / 10;
            }
            Console.Write(resultString);
            /* ВТОРОЙ ВАРИАНТ ЧЕРЕЗ ЦИКЛ */

            Console.ReadLine();
        }
    }
}
