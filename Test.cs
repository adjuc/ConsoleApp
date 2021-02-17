using System;

namespace HelloWorld
{
    public class CalculateClass
    {
        int l1, l2, l3, l4, l5, l6, l7, l8, l9;
        public CalculateClass(int v1, int v2, int v3, int v4, int v5, int v6, int v7, int v8, int v9)
        {
            l1 = v1;
            l2 = v2;
            l3 = v3;
            l4 = v4;
            l5 = v5;
            l6 = v6;
            l7 = v7;
            l8 = v8;
            l9 = v9;
            if (l9 == 0)
            {
                if (l1 > l2) 
                {
                    return;
                }
                else
                {
                    l1 =l1 + 1; 
                }
                if (l2 > l3) 
                {
                    return;
                }
                else
                { 
                l2 = l2 + 1;
                } 
                if (l3 > l4) 
                {
                    return;
                }
                else
                { 
                l3 = l3 + 1;
                }                  
                if (l6 > l7) 
                {
                    return;
                }
                else
                { 
                l6 = l6 + 1;
                }  
            }
            else
            {
                if (l1 > l2) 
                {
                    return;
                }
                else
                {
                    l1 =l1 + 1; 
                }
                if (l2 > l3) 
                {
                    return;
                }
                else
                { 
                l2 = l2 + 1;
                } 
                if (l3 > l4) 
                {
                    return;
                }
                else
                { 
                l3 = l3 + 1;
                }  
                
                if (l6 > l7) 
                {
                    return;
                }
                else
                { 
                l6 = l6 + 1;
                l7 = l7 + 1;
                }  
            }                      
        }
        public int Sum()
        {
            return(l1+l2+l3+l4+l5+l6+l7+l8+l9);
        }
    }
    
}
