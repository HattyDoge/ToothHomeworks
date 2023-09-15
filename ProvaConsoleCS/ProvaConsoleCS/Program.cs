using System.Collections.Generic;

namespace ProvaConsoleCS
{
    internal class Program
    {
        static bool Check(string ex) 
        {
            List<char> stack = new List<char>();
            foreach ( char s in ex) 
            {
                if (s == '(' || s == '{' || s == '[') ;
            }
            return true;
        }
        static void Main(string[] args)
        {
            //  controllo bilanciamento delle parentesi 

        }
    }
}