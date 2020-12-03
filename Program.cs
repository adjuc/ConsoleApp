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
            Console.WriteLine("Simple sum is " + sum.ToString()); 
            ICalculate iCal = new Calculate();
            Console.Write("ProductOf2:" + iCal.CalculateProductOf2(2,4).ToString() + "\n");
            Console.Write("SumOf8:" + iCal.CalculateSumOf8(1,2,3,4,5,6,7,8).ToString() + "\nEnd of procedure\n");
        }
    }
}