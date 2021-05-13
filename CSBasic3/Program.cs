using System;
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
        }
    }
}