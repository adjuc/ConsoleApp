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
            Console.WriteLine("This is a hotfix bracnh fixed in commit 4"); 
            Console.WriteLine("This is a hotfix2 branch fixed in commit 5");
            Console.WriteLine("This is first commit into hotfix3 branch");  
            Console.WriteLine("Simple sum is " + sum.ToString()); 
            Console.WriteLine("SumClass sum of 10: " + C1.CalculateSumOf10(1,2,3,4,5,6,7,8,9,10).ToString()); 
            ICalculate iCal = new Calculate();
            Console.Write("ProductOf2:" + iCal.CalculateProductOf2(2,4).ToString() + "\n");
            Console.Write("DivisionOf 8/4:" + iCal.CalculateDivision(8, 4).ToString()+ "\n");
            Console.Write("SumOf8:" + iCal.CalculateSumOf8(1,2,3,4,5,6,7,8).ToString() + "\n");
            Console.Write("SumOf9:" + iCal.CalculateSumOf9(1,2,3,4,5,6,7,8,9).ToString() + "\n");
            Console.Write("SumOf10:" + iCal.CalculateSumOf10(1,2,3,4,5,6,7,8,9,10).ToString() + "\n");            
            Console.Write("End of procedure\n");
        }
    }
}