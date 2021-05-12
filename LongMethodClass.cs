using System;

namespace ConsoleAppDemo1
{
    internal class LongMethodClass 
    {
        public string GetLongString(string s1)
        {
            string s = new string(s1);
            s = s + " 1"; 
            s = s + " 2";
            s = s + " 3";
            s = s + " 4";
            s = s + " 5"; 
           
            s = s + " 19";
            s = s + " 20";
            s = s + " 30";
            s = s + " 31";  
            s = s + " 32";
            s = s + " 33";
            s = s + " 34";
            s = s + " 35";            
            return(s);
        }
    }
}
