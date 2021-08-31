using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic7
{
    class Products
    {
        private List<string> list = new List<string>();
        public Products()
        {
            list.Add("곱창");
            list.Add("김치볶음밥");
            list.Add("육회");
            list.Add("마카롱");
            list.Add("샐러드");
        }
        public string this[int i]{
            get { return list[i]; }
            set { Console.WriteLine(i + "번째 상품 설정"); }
        }
    }
    class Program
    {
        class Wanted<T>
        // where T : Student
        {
            public T Value;
            public Wanted(T value)
            {
                this.Value = value;
            }
        }
        class Student
        {
            public override string ToString()
            {
                return "학생";
            }
        }
        static void Main(string[] args)
        {
            Products ps = new Products();
            Random rs = new Random();
            int i = rs.Next(0, 5);
            Console.WriteLine(ps[i]);

            Wanted<string> ws = new Wanted<string>("String");
            Wanted<int> wi = new Wanted<int>(100);
            Wanted<Student> wstu = new Wanted<Student>(new Student());
            Console.WriteLine(ws.Value);
            Console.WriteLine(wi.Value);
            Console.WriteLine(wstu.Value);
        }
    }
}
