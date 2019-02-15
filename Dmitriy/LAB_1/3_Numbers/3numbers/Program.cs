using System;

namespace _3numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber; 
            int secondNumber;
            int thirdNumber;
            Console.Write("Enter FIRST  digit: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter SECOND digit: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter THIRD  digit: ");
            thirdNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("SUMM: {0}", firstNumber + secondNumber + thirdNumber);
            Console.WriteLine("MULTIPLY: {0}", firstNumber * secondNumber * thirdNumber);
            Console.WriteLine("AVERAGE: {0}", (firstNumber + secondNumber + thirdNumber) / 3.0);
            Console.ReadKey();
        }
    }
}
