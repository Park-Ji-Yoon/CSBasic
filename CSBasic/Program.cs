using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class Program
    {
        // var 키워드는 지역변수로만 사용 가능
        // var name = "박지윤";
        static void Main(string[] args)
        {
            // keyword
            // int as;

            //context keyword
            var name = "박지윤";
            var var = "함기훈";

            // 식별자 identifier
            int alpha;
            int Alpha;
            // int break;
            // int 263alpha;
            // int has space;
            // int 👍👍🙌;
            int 한글숫자;

            /// xml 주석
            // inline comment
            /*
             * comment
             */

            Console.Write("이건 안개행");
            Console.Write("입니다\n");
            Console.WriteLine("");
            Console.WriteLine("이건 개행");

            // 자료형 (Data Type)
            // Integer
            Console.WriteLine(53 + 272 - 12);
            Console.WriteLine(3 * 8 * 2);
            // C#에서는 정수 나눗셈을 하면 정수로 나옴
            Console.WriteLine(14 / 2); // 7
            Console.WriteLine(14 / 3); // 4
            Console.WriteLine(14 % 2);

            // Real Number
            Console.WriteLine(13.123);
            Console.WriteLine(0);
            Console.WriteLine(0.0);
            // C#에서는 실수 나눗셈을 하면 실수로 나옴
            Console.WriteLine(14.0 / 2.0); // 7.0
            Console.WriteLine(14.0 / 3.0); // 4.6666667
            // Console.WriteLine(14.0 % 3.0);
            Console.WriteLine(14 / 3); // 4
            Console.WriteLine(14.0 / 3); // 4.6666667
            Console.WriteLine(14 / 3.0); // 4.6666667
            Console.WriteLine(14.0 / 2.0); // 4.6666667

            // Character
            Console.WriteLine('A'); // character (문자)
            // String
            Console.WriteLine("A"); // string (문자열)
            // Escape Character
            Console.WriteLine("\t 탬 \\ 역슬래시 \n 개행 \" 쌍따옴표");
            // 앞글자를 포함해서 8byte
            Console.WriteLine("미\t림여자정보과학고");
            Console.WriteLine("미림\t여자정보과학고");
            Console.WriteLine("미림여\t자정보과학고");
            Console.WriteLine("미림여자\t정보과학고");
            Console.WriteLine("미림여자정\t보과학고");
            Console.WriteLine("미림여자정보\t과학고");
            Console.WriteLine("미림여자정보과\t학고");
        }
    }
}
