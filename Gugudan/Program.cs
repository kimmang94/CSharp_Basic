using System;

namespace CSharp
{
    class Program
    {
        // 오버로딩 함수 이름의 재사용
       
       static void Main(string[] args)
        {
            for (int i = 2; i <= 9; i++ )
            {
                Console.WriteLine( $"{i}단");
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine($"{i} X {j} = {i * j}");
                }
            }
        }
    }
}
