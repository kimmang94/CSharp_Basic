using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main 은 진입하는 함수이다 프로그램에서 유일한존재

            // 주석의 방법 1
            /*
             주석의 방법 2
             */

            // 데이터 + 로직
            // 체력, 마나 : 데이터
            // 체력이 0 이되면 죽는다 : 로직

            // 가장 기본적인 형태인 정수(integer)
            // 정수는 양의정수, 0, 음의정수가 존재한다

            // 이것을 저장해 두려면 "변수" 가 필요하다!
            // 일종의 데이터를 저장하는 바구니
            // 타입 변수명 = 값; 
            int hp;

            hp = 100;

            // 한번에도 가능하다

            int mp = 50;

            // 출력하는법(구)
            Console.WriteLine("Hello Number! {0}", hp);
            // {0} 에 hp 가 들어간다.

            // 출력하는법(신)
            Console.WriteLine($"Hello Number! {hp}");

            Console.WriteLine("Hello World!");
        }
    }
}
