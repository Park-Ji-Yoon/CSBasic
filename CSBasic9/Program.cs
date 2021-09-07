using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic9
{
    class Program
    {
        class WrongBoxSizeException : Exception
        {
            public WrongBoxSizeException(string message) : base(message)
            {

            }
        }
        class Box
        {
            private int width;
            private int Width
            {
                get { return width; }
                set
                {
                    if(value > 0){ width = value; }
                    else { throw new WrongBoxSizeException("너비는 자연수를 입력하세요"); }
                }
            }
            private int height;
            private int Height
            {
                get { return width; }
                set
                {
                    if (value > 0) { height = value; }
                    else { throw new WrongBoxSizeException("높이는 자연수를 입력하세요"); }
                }
            }
            public Box(int width, int height)
            {
                Width = width;
                Height = height;
            }
            public int Area()
            {
                return this.width * this.height;
            }
        }
        static void Main(string[] args)
        {
            Box b = new Box(10, 10);
            // Box be = new Box(10, -10);
            // Box bz = new Box(0, 0);

            Console.WriteLine("입력 : ");

            Boolean isFlag = true;
            while (isFlag)
            {
                try
                {
                    string input = Console.ReadLine();
                    int index = int.Parse(input);
                    if(index == 42)
                    {
                        throw new OverflowException(); // 강제 예외 발생
                    }
                    Console.WriteLine("입력 숫자 : " + index);
                    isFlag = false;
                }catch(FormatException exception)
                {
                    Console.WriteLine("예외가 발생했습니다. 숫자를 아라비아 숫자로 입력해주세요");
                }
                catch(OverflowException exception)
                {
                    Console.WriteLine("예외가 발생했습니다. " + int.MinValue + "와 " + int.MaxValue + "사이의 수를 입력해주세요");
                }
                catch (Exception exception)
                {
                    Console.WriteLine("예외가 발생했습니다");
                    // return;
                    Console.WriteLine(exception.GetType());
                    Console.WriteLine(exception.Message);
                    Console.WriteLine(exception.StackTrace);
                }
                finally
                {
                    Console.WriteLine("-----------------------");
                }
            }
        }
    }
}
