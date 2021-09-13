using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSBasic10
{
    class Program
    {
        public static void TestMethod()
        {
            for(int i=0; i<1000; i++)
            {
                Console.Write("A");
            }
        }
        public delegate void SendString(string message);
        public static void Hello(string message)
        {
            Console.WriteLine("안녕하세요 " + message + "씨..!");
        }
        public static void GoodBye(string message)
        {
            Console.WriteLine("안녕히 가세요 " + message + "씨~");
        }
        class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }
        }
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product(){Name="감자", Price=500},
                new Product(){Name="사과", Price=600},
                new Product(){Name="고구마", Price=700},
                new Product(){Name="배추", Price=400},
                new Product(){Name="양상추", Price=300}
            };
            // 정렬
            /*products.Sort(SortWithPrice);*/
            /*products.Sort(delegate(Product x, Product y) {
                return x.Price.CompareTo(y.Price);
            });*/
            /*products.Sort((x, y) => { 
                return x.Price.CompareTo(y.Price);
            });*/
            products.Sort((x, y) => x.Price.CompareTo(y.Price));

            //출력
            foreach (var item in products)
            {
                Console.WriteLine(item.Name + " : " + item.Price);
            }

            SendString sayHello, sayGoodbye, multiDelegate;
            sayHello = Hello;
            sayGoodbye = GoodBye;
            multiDelegate = sayHello + sayGoodbye;
            multiDelegate("박지윤");
            Console.WriteLine();
            multiDelegate -= sayGoodbye;
            // multiDelegate = multiDelegate - sayGoodbye;
            multiDelegate("박지윤");
            multiDelegate += sayHello;
            Console.WriteLine();
            multiDelegate("박지윤");

            Thread threadA = new Thread(TestMethod);
            Thread threadB = new Thread(delegate()
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.Write("B");
                }
            });
            Thread threadC = new Thread(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.Write("C");
                }
            });

            threadA.Start();
            threadB.Start();
            threadC.Start();
        }

        /*private static int SortWithPrice(Product x, Product y)
        {
            return x.Price.CompareTo(y.Price);
        }*/
    }
}
