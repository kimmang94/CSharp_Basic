using System;

namespace CSharp
{
    class Program
    {
        static int Factorial(int n)
        {
            int ret = 1;
            for (int num = 1; num <= n; num++)
            {
                ret *= num;
            }

            return ret;
        }
       static void Main(string[] args)
        {

            // n! = n * (n-1) * ... * 1
            int ret = Factorial(5);
        }
    }
}
