using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic4
{
    class MyMath
    {
        public static double PI = 3.141592;
        public static void Greeting()
        {
            // Console.WriteLine(somenumber);
            Console.WriteLine("Greeting!");
        }
    }
    class Car
    {
        int carNumber;
        DateTime inTime;
        DateTime outTime;

        public void SetInTime()
        {
            this.inTime = DateTime.Now;
        }
        public void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }
    }
    class Program
    {
        class FirstClass
        {

        }
        class SecondClass
        {

        }
        static void Main(string[] args)
        {
            Car[] cara = new Car[10];

            Random random = new Random();
            Console.WriteLine(random.Next());
            Console.WriteLine(random.Next(100));
            Console.WriteLine(random.Next(1, 19));
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());

            List<int> list = new List<int>() { 52, 273, 32, 64 };

            foreach (var item in list)
            {
                Console.WriteLine("Count: " + list.Count + "\titem:" + item);
                //list.Remove(item);
            }

            Console.WriteLine(Math.Abs(-52273));
            Console.WriteLine(Math.Ceiling(52.273));
            Console.WriteLine(Math.Floor(52.273));
            Console.WriteLine(Math.Round(52.263));
            Console.WriteLine(Math.Round(52.563));
            Console.WriteLine(Math.Max(52, 273));
            Console.WriteLine(Math.Min(52, 273));

            Product product = new Product();
            product.name = "감자";
            product.price = 2000;

            Console.WriteLine(product.name + ": " + product.price + "원");

            Product productA = new Product() { name = "짜장면", price = 5500 };
            Product productB = new Product() { name = "짬봉", price = 8000 };
            Product productC = new Product() { name = "탕수육" };
            Product productD = new Product() { price = 9999999 };
            Product productE = new Product() { price = 30000, name = "양장피" };

            List<Student> students = new List<Student>() {
                new Student() { name = "윤인성", grade = 1 },
                new Student() { name = "윤이성", grade = 2 },
                new Student() { name = "윤삼성", grade = 3 },
                new Student() { name = "윤사성", grade = 4 },
                new Student() { name = "윤오성", grade = 5 },
                new Student() { name = "윤육성", grade = 6 },
            };

            for (int q = 0; q < students.Count; q++)
            {
                if (students[q].grade > 1)
                {
                    students.RemoveAt(q);
                    // students.Remove(student[i]);
                }
            }

            for (int i = students.Count - 1; i >= 0; i--) {
                if (students[i].grade > 1){
                    students.RemoveAt(i);
                }
            }

            foreach (var item in students)
            {
                Console.WriteLine(item.name + " : " + item.grade);
            }
        }
    }
}