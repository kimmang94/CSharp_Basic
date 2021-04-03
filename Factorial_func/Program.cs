using System;

namespace CSharp
{
    class Program
    {
        static int Factorial(int n)
        {
            if (n <= 1)
                return 1;
            return n * Factorial(n - 1);
        }
       static void Main(string[] args)
        {

            // 5! = 5 * (4!)
            int ret = Factorial(5);
            Console.WriteLine(ret);
        }
    }
}
