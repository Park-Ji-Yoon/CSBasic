using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic5
{
    class Box
    {
        private int width;
        public int Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("양수를 입력해주세요");
                }
            }
        }
        private int height;
        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("양수를 입력해주세요");
                }
            }
        }
        public int Area
        {
            get { return this.Width * this.Height; }
        }
        public Box(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }
    }
    class Product
    {
        public static int counter = 0;
        public readonly int id;
        public string name;
        public int price;
        public Product(string name, int price)
        {
            // Product.counter = counter + 1;
            counter++;
            this.id = counter;
            this.name = name;
            this.price = price;
        }
        public override string ToString()
        {
            return this.id + " : " + this.name + " (" + this.price + "won)";
        }
        ~Product()
        {
            // Console.WriteLine(this.name + "의 소멸자 호출");
            Console.WriteLine(this.name + "曰 나 주거");
        }
    }
    class Sample
    {
        public static int value;
        static Sample()
        {
            value = 10;
            Console.WriteLine("정적 생성자 호출");
        }
    }
    class Program
    {
        int someModifier = 0;
        public int instanceVariable = 10;
        public int instanceMethod() { return 0; }
        class MyMath
        {
            public static int Abs(int input)
            {
                return (input < 0) ? -input : input;
                /*if(input<0)
                {
                    return -input;
                }
                else
                {
                    return input;
                }*/
            }
            public static double Abs(double input)
            {
                return input < 0 ? -input : input;
            }
            // Abs(long)
            public static long Abs(long input)
            {
                return input < 0 ? -input : input;
            }
            /*// Abs(long)
             * Method signature가 같은 경우 오버로딩 불가!
            public static int Abs(long a2)
            {
                return 0;
            }*/
        }
        class Test
        {
            public void TestMethod()
            {
                Program.Main(new string[] { "" });
            }
            // Method Signature
            public int Sum(int min, int max)
            {
                int output = 0;
                for (int i = min; i <= max; i++)
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
                Console.WriteLine("Print() 메서드 호출됨");
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

            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-273));
            Console.WriteLine(MyMath.Abs(52.273));
            Console.WriteLine(MyMath.Abs(999999999999999));

            Product productA = new Product("감자", 2300);
            Product productB = new Product("옥수수", 4500);
            Product productC = new Product("고구마", 1200);

            // Console.WriteLine(productA.id + " : " + productA.name);
            Console.WriteLine(productA.ToString());
            Console.WriteLine(productB.ToString());
            Console.WriteLine(productC.ToString());
            Console.WriteLine("작물이 " + Product.counter + "개 생성되었습니다.");

            // 정적 생성자는 클래스가 처음 로딩될 때 한 번만 호출됨
            Console.WriteLine("첫 번째 위치");
            Sample sample = new Sample();
            Console.WriteLine("두 번째 위치");
            Console.WriteLine(Sample.value);
            Console.WriteLine("세 번째 위치");

            Box box = new Box(10, 200);
            Console.WriteLine(box.Area);
            Box wrongBox = new Box(-10, -5);
            Console.WriteLine(wrongBox.Area);
        }
    }
}