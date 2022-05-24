using System;

namespace Wellahealthass2
{
    class Program
    {
        static void Main(string[] args)
        {
           string myName =  "Victor";
           char a = 'G';
           short s = 56;
           int i = 16;
           uint ui =67;
           double d =5.77;
           decimal dec =564.5m;
           bool isVerified = false;
           byte r = 254;
           float num1 = 56f;

           
           //this is implicit conversion
           short t = 56;
           int myint = t;


           //this is explicit 
           double h =577;
           int n = (int)h;

















            Console.WriteLine(myName);
            Console.WriteLine(a);
            Console.WriteLine(num1);
            Console.WriteLine(isVerified);
            Console.WriteLine(i);
            Console.WriteLine(dec);
            Console.WriteLine(s);
            Console.WriteLine(ui);
            Console.WriteLine(d);
            Console.WriteLine(r);
            Console.WriteLine(myint);
            Console.WriteLine(n);
        }
    }
}
