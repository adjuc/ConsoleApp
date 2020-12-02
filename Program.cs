using System;

namespace ConsoleAppDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello ConsoleAppDemo1!"); 
            CalculateSumClass C1 = new CalculateSumClass();
            int sum = C1.Calculate(1,2,3,4,5,6,7,8);
            Console.WriteLine("Sum is " + sum.ToString()); 
        }
    }
}