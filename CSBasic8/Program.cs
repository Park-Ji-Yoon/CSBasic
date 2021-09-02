
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic8
{
    class Program
    {
        class Parent { }
        class Child : Parent, IDisposable, IComparable
        {
            public int CompareTo(object obj)
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }
        class TestClass : IBasic
        {
            public int TestProperty { 
                get => 0; 
                set => value = 0; 
            }

            public int TestInstanceMethod()
            {
                return 0;
            }
        }
        class Dummy : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine("리소스가 해제되었습니다");
            }
        }
        class Product : IComparable
        {
            public String Name { get; set; }
            public int Price { get; set; }

            public int CompareTo(object obj)
            {
                return Price.CompareTo((obj as Product).Price);
                // return (-1) * Price.CompareTo((obj as Product).Price);
            }

            public override string ToString()
            {
                return Name + " : " + Price;
            }
        }

        static void Main(string[] args)
        {
            // 파일 쓰기
            File.WriteAllText(@"C:\Users\purun\Desktop\test.txt", "안녕하세요");

            // 파일 읽기
            Console.WriteLine(File.ReadAllText(@"C:\Users\purun\Desktop\test.txt"));

            // Stream으로 파일 쓰기
            using (StreamWriter writer = new StreamWriter(@"C:\Users\purun\Desktop\test2.txt"))
            {
                writer.WriteLine("안녕하세요");
                writer.WriteLine("streamwriter 클래스 사용해서");
                writer.WriteLine("파일에 글 써봅니다");
                for (int i = 0 ; i < 10; i++){
                    writer.WriteLine("반복문");
                }
            }

            // Stream으로 파일 읽기
            using(StreamReader reader = new StreamReader(@"C:\Users\purun\Desktop\test2.txt"))
            {
                string line;
                int lineNumber = 1;
                while((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(lineNumber + " : " + line);
                    lineNumber++;
                }
            }

                Child child = new Child();
            Parent childParent = new Child();
            IDisposable childDisposable = new Child();
            IComparable childComparable = new Child();

            IBasic basic = new TestClass();
            basic.TestProperty = 3;

            using(Dummy d = new Dummy())
            {
                Console.WriteLine("뭔가 했습니다.");
            }

            List<Product> list = new List<Product>()
           {
               new Product{Name = "고구마", Price = 1500 },
               new Product{Name = "메론", Price = 4000 },
               new Product{Name = "딸기", Price = 500 },
               new Product{Name = "사과", Price = 2000 },
               new Product{Name = "감자", Price = 1000 },
            };
            list.Sort();
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
