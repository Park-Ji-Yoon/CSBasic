using System;
using System.Threading;

namespace CSBasic3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[100];
            Console.WriteLine(intArray.Length);
            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[99]);
            // Console.WriteLine(intArray[100]); // 범위 추가
            // Console.WriteLine(intArray[-]); // 음수 사용 불가
            int i = 0;
            int[] intArray2 = { 52, 273, 32, 65, 103 };
            while (i < intArray2.Length)
            {
                Console.WriteLine(i + "번째 출력" + intArray2[i]);
                i++;
            }
            string input;
            do
            {
                Console.Write("입력(종료:exit):");
                input = Console.ReadLine();
            } while (input != "exit");
            /*for (int j = '가'; j <= '힣'; j++)
            {
                Console.WriteLine((char)j);
            }*/

            int[] intArray3 = { 1, 2, 3, 4, 5, 6 };
            for (int k = intArray3.Length - 1; k >= 0; k--)
            {
                Console.WriteLine(intArray3[k]);
            }
            for (int k=intArray3.Length; k>0; k--)
            {
                Console.WriteLine(intArray3[k-1]);
            }

            string[] fruits = { "사과", "배", "수박", "포도", "파인애플", "딸기", "바나나" };
            foreach(var item in fruits)
            {
                Console.WriteLine(item);
            }

            for(i = 0; i < 10; i++)
            {
                for(int j=0; j<i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            for(i = 0; i< 10; i++)
            {
                for(int j=0; j<10-i; j++)
                {
                    Console.Write(' ');
                }
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            // 대소문자 변환
            string input3 = "Potato Tomato";
            Console.WriteLine(input3.ToUpper());
            Console.WriteLine(input3.ToLower());
            input3.ToLower(); // 헛고생
            Console.WriteLine(input); // 기존 그대로 출력됨

            string foods = "감자 고구마 토마토";
            string[] foodsArray = foods.Split(new char[] { ' ' });
            foreach(var item in foodsArray)
            {
                Console.WriteLine(item);
            }

            string path = "C:\\oraclexe\\app\\oracle\\product\\11.2.0\\server\\bin;C:\\Program Files (x86)\\Common Files\\Oracle\\Java\\javapath;%SystemRoot%\\system32;%SystemRoot%;%SystemRoot%\\System32\\Wbem;%SYSTEMROOT%\\System32\\WindowsPowerShell\\v1.0\\;%SYSTEMROOT%\\System32\\OpenSSH\\;%JAVA_HOME%\\bin;C:\\Program Files\\dotnet\\;C:\\Program Files\\Microsoft SQL Server\\130\\Tools\\Binn\\;C:\\Program Files\\Microsoft SQL Server\\Client SDK\\ODBC\\170\\Tools\\Binn\\;C:\\Program Files\\Git\\cmd;C:\\Program Files\\nodejs\\;C:\\Program Files\\MongoDB\\Server\\4.4\\bin;C:\\Program Files\\MySQL\\MySQL Server 8.0\\bin;";
            string[] paths = path.Split(new char[] { ';' });
            foreach(var item in paths)
            {
                Console.WriteLine(item);
            }

            string dirtyInput = " text    um \n\t";
            Console.WriteLine("[" + dirtyInput + "]");
            Console.WriteLine("[" + dirtyInput.Trim() + "]");

            string[] foodsArray2 = { "감자", "고구마", "토마토", "가지" };
            Console.WriteLine(string.Join(" ", foodsArray2)); // space 1개
            Console.WriteLine(string.Join(",", foodsArray2));
            Console.WriteLine(string.Join(";", foodsArray2));
            Console.WriteLine(string.Join(" ", foodsArray2)); // tab 1개

            Console.SetCursorPosition(1, 1);
            Console.WriteLine("[     ]");
            Thread.Sleep(1000);
            Console.SetCursorPosition(1, 1);
            Console.WriteLine("[#    ]");
            Thread.Sleep(1000);
            Console.SetCursorPosition(1, 1);
            Console.WriteLine("[##   ]");
            Thread.Sleep(1000);
            Console.SetCursorPosition(1, 1);
            Console.WriteLine("[###  ]");
            Thread.Sleep(1000);
            Console.SetCursorPosition(1, 1);
            Console.WriteLine("[#### ]");
            Thread.Sleep(1000);
            Console.SetCursorPosition(1, 1);
            Console.WriteLine("[#####]");
            Thread.Sleep(1000);

            int x = 1;
            while(x < 50)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                if(x % 3 == 0)
                {
                    Console.WriteLine("__@");
                }else if(x % 3 == 1)
                {
                    Console.WriteLine("_^@");
                }
                else if(x % 3 == 2)
                {
                    Console.WriteLine("^_@");
                }
            }
        }
    }
}