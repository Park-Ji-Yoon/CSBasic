using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic11
{
    class Program
    {
        class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public override string ToString()
            {
                return Name + " : " + Price;
            }
        }
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product(){Name = "고구마", Price = 1500},
                new Product(){Name = "감자", Price = 1000},
                new Product(){Name = "옥수수", Price = 3000},
                new Product(){Name = "사과", Price = 1800},
                new Product(){Name = "토마토", Price = 5500},
                new Product(){Name = "복숭아", Price = 9900},
                new Product(){Name = "자두", Price = 2000},
                new Product(){Name = "수박", Price = 8900},
            };
            var output3 = from item in products 
                          where item.Price > 1500 
                          orderby item.Name ascending 
                          select item;
            foreach (var item in output3)
            {
                Console.WriteLine(item);
            }

            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> output = new List<int>();

            output = (from item in input where item % 2 == 0 orderby item descending select item).ToList();
            /*foreach(var item in input)
            {
                if(item % 2 == 0)
                {
                    output.Add(item);
                }
            }*/
            foreach(var item in output)
            {
                Console.WriteLine(item);
            }

            var output2 = from item in input
                          where item % 2 == 0
                          select new
                          {
                              A = item * 2,
                              B = item * item,
                              C = 100
                          };
            foreach (var item in output2)
            {
                Console.WriteLine(item.A + " / " + item.B + " / " + item.C);
            }
        }
    }
}
