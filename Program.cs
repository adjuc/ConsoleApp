using System;

namespace ConsoleAppDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello ConsoleAppDemo1!"); 
            CalculateSumClass C1 = new CalculateSumClass();
            int sum = C1.CalculateSumOf8(1,2,3,4,5,6,7,8);
            Console.WriteLine("Sum is " + sum.ToString()); 
            Calculate Cal = new Calculate();
            Console.Write("SumOf8:" + Cal.CalculateSumOf8(1,2,3,4,5,6,7,8).ToString() + "\nEnd of procedure\n");
        }
    }
}