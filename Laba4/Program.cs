using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    public class A
    {
        protected int a = 27;
        private int b = 9;
        public int c
        {
            get
            {
                if (a > b) return a;
                else return b;
            }
            set
            {
                c = value;
            }

        }
        public class B : A
        {
            private int d = 15;

            public int c2
            {
                get
                {
                    if (d < a) return d %= 10;
                    else return a;
                }
                set
                {
                    c2 = value;
                }
            }
            
        }
        class Programm
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Вакурова Екатерина.Лабораторная 4");

                A obj1 = new A();
                Console.WriteLine("  1: " + obj1.c);
                B obj2 = new B();
                Console.WriteLine("  2: " + obj2.c2);
                Console.ReadKey();
            }
        }
    }
}