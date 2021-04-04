using System;

namespace CSharp
{
    // 객체 위주로 생각 (OOP : Object Oriented Programming)
    // 코드내의 모든 것
    // 객체 설계
    
    // 어떤방식으로 묘사해야함
    // Knight
    // 속성 : HP, Attack, Position, ... 
    // 기능 : Move, Attack, Die, ... 
    
    class Knight
    {
        public int hp;
        public int attack;


        public void Move()
        {
            Console.WriteLine("Knight Move");
        }

        public void Attack()
        {
            Console.WriteLine("Knight Attack");
        }
    }

    class Program
    {
       static void Main(string[] args)
        {
            Knight knight = new Knight();

            knight.hp = 100;
            knight.attack = 10;

            knight.Move();
            knight.Attack();
        }
    }
}
