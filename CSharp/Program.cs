using System;

namespace CSharp
{
    class Program
    {

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

        }

        static void AddOne(ref int number)
        {
            number = number + 1;
        }
        static int AddOne2(int number)
        {
            return number + 1;
        }

        static void Main(string[] args)
        {
            // 복사(짝퉁) ref : 참조(진퉁)
            int a = 0;
            Program.AddOne(ref a);

            Console.WriteLine(a);
            // 아래 버전이 더좋다 
            a = Program.AddOne2(a);

            Console.WriteLine(a);

            int num1 = 1;
            int num2 = 2;
            Program.Swap(ref num1, ref num2);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }
    }
}
