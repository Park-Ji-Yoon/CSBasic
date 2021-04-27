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

        // var something = "blahblah";
        static void Main(string[] args)
        {
            // keyword
            // int as;

            // context keyword
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

            // 문자열 연결 연삱
            // concat concatenate operator
            // concatenation operator
            Console.WriteLine("ABC" + "EFG");
            Console.WriteLine('A' + 'E');
            Console.WriteLine("ABC" + 'E');

            Console.WriteLine("ABC"[2]);

            Console.WriteLine("ABC"[3]);

            // bool
            bool isPlaye = true;
            bool isDeath = false;

            // comparison operator
            Console.WriteLine(52 == 163);
            Console.WriteLine(52 != 163);
            Console.WriteLine(52 > 163); // greater than
            Console.WriteLine(52 < 163); // less than
            Console.WriteLine(52 >= 163);
            Console.WriteLine(52 <= 163);

            // Logic operator
            Console.WriteLine(!(true));
            Console.WriteLine(true || false);
            Console.WriteLine(true && false);

            // 단항연산자 - unary operator
            Console.WriteLine(!(true));
            int i = 0;
            i++;

            // 이항연산자 - binary operator
            i = 1 + 2;

            // 삼항연산자 - ternary operator
            int j;
            j = (i > 3) ? 0 : 1;

            // Console.WriteLine(3 < i < 8);
            Console.WriteLine(3 < i && i < 8);
            Console.WriteLine(3 < i || i < 8);
            Console.WriteLine(i < 3 || 8 < i);

            // int
            int a = 214748340;
            int b = 10000000;
            Console.WriteLine((long)a + b);

            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(double.MaxValue);

            // Console.WriteLine(-int.MinValue);
            Console.WriteLine(-int.MaxValue);

            Console.WriteLine(3L);
            Console.WriteLine(3l);

            Console.WriteLine(3);
            Console.WriteLine(3.0);

            char c = 'a';
            Console.WriteLine(c);

            // sizeof(자료형)
            Console.WriteLine("int : " + sizeof(int));
            Console.WriteLine("int : " + sizeof(long));
            Console.WriteLine("int : " + sizeof(float));
            Console.WriteLine("int : " + sizeof(double));
            Console.WriteLine("int : " + sizeof(char));

            bool IsLive = true;

            // 증감 연산자
            // 전위, 후위에 따라서 출력값이 변할 수 있으니 주의
            int num = 10;
            Console.WriteLine(num++);
            Console.WriteLine(++num);
            Console.WriteLine(num--);
            Console.WriteLine(--num);

            // 복합 대입 연산자
            int output = 0;
            output += 52;
            output = output + 52;
            output *= 10;
            output = output * 10;
            Console.WriteLine(output);

            // 문자열 연결 연산자를 사용한 복합 연산자
            String output3 = "Hello" ;
            output3 += " World";
            output3 = output3 + "?!";
            Console.WriteLine(output3);

            // 자료형 검사
            int _int = 273;
            long _long = 522454654656546;
            float _float = 52.273F;
            double _double = 52.273;
            char _char = '귤';
            string _string = "문자열";
            Console.WriteLine(_int.GetType());
            Console.WriteLine(_long.GetType());
            Console.WriteLine(_float.GetType());
            Console.WriteLine(_double.GetType());
            Console.WriteLine(_char.GetType()); 
            Console.WriteLine(_string.GetType());

            var somea = "마음에 드는 문자열";
            var someb = 42;
            var somec = 3.1415962;
            Console.WriteLine(somea.GetType());
            Console.WriteLine(someb.GetType());
            Console.WriteLine(somec.GetType());

            // 입력 (콘솔 입력)
            string input;
            while (true)
            {
                Console.Write("입력 : ");
                input = Console.ReadLine();
                if (input.Equals("q"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine(input);
                }
            }

            var a1 = (int)10.0;
            var b1 = (float)10;
            var c1 = (double)10;

            long longNumber = 2147483637L + 2147483637L;
            int intNumber = (int)longNumber;
            Console.WriteLine(intNumber);

            long longNumber2 = 52773;
            int intNumber2 = (int)longNumber2;
            Console.WriteLine(longNumber2);

            Console.WriteLine("int, long, float, double 맥스밸류");
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(double.MaxValue);

            Console.WriteLine("문자열의 숫자로의 형변환");
            Console.WriteLine(int.Parse("52"));
            Console.WriteLine(long.Parse("273"));
            Console.WriteLine(float.Parse("52.273"));
            Console.WriteLine(double.Parse("103.52"));
            Console.WriteLine(int.Parse("52").GetType());
            Console.WriteLine(long.Parse("273").GetType());
            Console.WriteLine(float.Parse("52.273").GetType());
            Console.WriteLine(double.Parse("103.52").GetType());

            try
            {
                Console.WriteLine(int.Parse("52.273"));
                Console.WriteLine(int.Parse("abc"));
            }
            catch(FormatException e)
            {
                Console.WriteLine("숫자를 입력하세요");
            }
            catch (Exception e)
            {
                Console.WriteLine("알 수 없는 에러 : " + e.Message);
            }

            // ToString()
            (10).ToString();
            (52.283).ToString();

            double numberToString = 52.273103;
            Console.WriteLine(numberToString.ToString("0.0"));
            Console.WriteLine(numberToString.ToString("0.00"));
            Console.WriteLine(numberToString.ToString("0.000"));
            Console.WriteLine(numberToString.ToString("0.0000"));

            // 숫자와 문자열 덧셈
            Console.WriteLine(52 + 273);
            Console.WriteLine("52" + 273);
            Console.WriteLine(52 + "273");
            Console.WriteLine("52" + "273");
            Console.WriteLine(52 + 2 + 273);
            Console.WriteLine(52 + "2" + 273);
            Console.WriteLine("52" + 2 + 273);
            Console.WriteLine(52 + 2 + "273");
            Console.WriteLine(52 + '1' + "273");

            int number = 52273;
            String outputA = number + "";

            char character = 'a';
            string outputB = character + "";
            Console.WriteLine(outputB);

            Console.WriteLine(bool.Parse("True"));
            Console.WriteLine(bool.Parse("true"));
            Console.WriteLine(bool.Parse("TRUE"));
            Console.WriteLine(bool.Parse("truE"));
            Console.WriteLine(bool.Parse("TrUe"));

            int outputInt = int.MinValue;
            // Console.WriteLine(-(long)outputInt);
            Console.WriteLine(-(-02148493648));
        }
    }
}
