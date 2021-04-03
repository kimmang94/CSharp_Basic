using System;

namespace CSharp
{
    class Program
    {
        // Method , Function
        /*
         * 한정자 반환형식 이름(매개변수목록)
         * {
         * }
         */

        static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }


        // 덧셈 함수

       
        static void Main(string[] args)
        {
            Console.WriteLine(Caculater.Add(2, 3));
        }
    }
}
