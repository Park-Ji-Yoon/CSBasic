using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic5
{
    class Program
    {
        class MethodExample
        {
            public int Power(int x)
            {
                return x * x;
            }

            public int Multi(int x, int y)
            {
                return x * y;
            }

            public void Print()
            {
                Console.WriteLine("Print() 메서드 호출됨");
            }
        }

        

        static void Main(string[] args)
        {
            MethodExample me = new MethodExample();
            Console.WriteLine(me.Power(10));
            Console.WriteLine(me.Power(20));
            Console.WriteLine(me.Multi(2123, 275));
            Console.WriteLine(me.Multi(100, 3210));
            me.Print();
        }
    }
}
