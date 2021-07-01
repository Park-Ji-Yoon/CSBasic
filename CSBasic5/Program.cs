using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic5
{
    class Program
    {
        public int instanceVariable = 10;
        public int instanceMethod()
        {
            return 0;
        }

        class MyMath
        {
            public static int Abs(int input)
            {
                /*if(input < 0)
                {
                    return -input;
                }
                else
                {
                    return input;
                }*/
                return (input < 0) ? -input : input;
            }
        }

        class Test
        {
            // Method Signature
            public int Sum(int min, int max)
            {
                int output = 0;
                for(int i = min; i <= max; i++)
                {
                    output += i;
                }
                return output;
            }
        }

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
            public void print()
            {
                Console.WriteLine("Print() 메서드 호출");
            }
        }

        static void Main(string[] args)
        {
            MethodExample me = new MethodExample();
            Console.WriteLine(me.Power(10));
            Console.WriteLine(me.Power(20));
            Console.WriteLine(me.Multi(25, 200));
            Console.WriteLine(me.Multi(27, 300));
            me.print();

            // min부터 max까지의 합 구하기
            Test test = new Test();
            Console.WriteLine(test.Sum(1, 100));

            // 클래스 메서드 사용 - 절댓값 구하기
            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-273));

            // 클래스 메서드에서는 인스턴수 변수나 메서드에 접근 불가
            // 객체를 만들어서 접근해야 한다.
            /*Console.WriteLine(instanceVariable);
            instanceMethod();*/

            Program p = new Program();
            Console.WriteLine(p.instanceVariable);
            p.instanceMethod();
        }
    }
}