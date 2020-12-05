using System;

namespace ConsoleAppDemo1
{
    internal class Calculate : ICalculate
    {
        public int CalculateSumOf8(int v1, int v2, int v3, int v4, int v5, int v6, int v7, int v8)
        {
            return(v1+v2+v3+v4+v5+v6+v7+v8);
        }
        public int CalculateProductOf2(int v1, int v2)
        {
            // forgot a comment
            int result = v1 * v2;
            return(result);
        }
        public int CalculateProductOf3(int v1, int v2, int v3)
        {
            // forgot a comment
            int result = v1 * v2 * v3;
            return(result);
        }
        public int CalculateDivision(int v1, int d1)
        {
            return(v1/d1);
        }
    }
}