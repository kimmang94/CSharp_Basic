using System;

namespace CSharp
{
    class Program
    {
        // 한줄 주석
        /*
         * 여러줄 주석 
         */
        static void Main(string[] args)
        {
            // 데이터 + 로직
            // 체력 0
            int hp;

            hp = 100;

            int mp = 50;

            Console.WriteLine("My Status\nHP:{0}\nMP:{1}",hp, mp);
        }
    }
}
