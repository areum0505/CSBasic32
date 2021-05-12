using System;

namespace CSBasic323
{
    class Program
    {
        static void Main(string[] args)
        {
            // 반복문과 배열
            int[] intArray = new int[100];
            Console.WriteLine(intArray.Length);
            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[99]);
            //Console.WriteLine(intArray[100]);    // 범위 초과
            //Console.WriteLine(intArray[-1]);      // 음수 사용 불가

            Console.WriteLine();

            // while / do while
            int i = 0;
            int[] intArray2 = { 52, 273, 32, 65, 103 };
            while (i < intArray2.Length)
            {
                Console.WriteLine(i + "번째 출력 : " + intArray2[i]);
                i++;
            }

            string input;
            do
            {
                Console.Write("입력 (종료 : exit) : ");
                input = Console.ReadLine();
            } while (input != "exit");

            Console.WriteLine();

            // for / 역 for
            for(int j = '가'; j <= '힣'; j++)
            {
                Console.Write((char)j);
            }
            Console.WriteLine();

            int[] intArray3 = { 1, 2, 3, 4, 5, 6 };
            for(int k = intArray3.Length - 1; k >= 0; k--)
            {
                Console.WriteLine(intArray3[k]);
            }
            for (int k = intArray3.Length; k > 0; k--)
            {
                Console.WriteLine(intArray3[k - 1]);
            }
        }
    }
}
