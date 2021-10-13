using System;

namespace ConsoleApp1
{
    class Program:C
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            A a2 = new A();
            B b3 = new B();
            b3.a = a1;

            B b4 = new B();
            b4.a = b3;

            C c5 = new C();
            c5.a = a1;
            c5.b = b4;
            c5.c = a2;
        }
    }
}
