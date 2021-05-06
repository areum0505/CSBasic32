using System;

namespace CSBasic323
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[100];
            Console.WriteLine(intArray.Length);
            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[99]);
            //Console.WriteLine(intArray[100]);    // 범위 초과
            //Console.WriteLine(intArray[-1]);      // 음수 사용 불가
        }
    }
}
