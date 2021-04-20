using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic32
{
    class Program
    {
        // var name = "김아름";
        static void Main(string[] args)
        {
            // keyword
            // int as;

            // context-keyword - 특정 위치에서만 키워드로 동작
            var name = "김아름";   // var 키워드는 지역변수로만 사용 가능
            // var var = "김아름";

            // 식별자 Identifier - 변수명이나 메서드명, 클래스명 같이 이름을 붙일 때 사용하는 단어
            int alpha;
            int Alpha;
            // int break;
            // int 123alpha;
            // int has space;
            // int 🙂;
            // int 한글;

            /// xml 주석
            // inline comment
            /*
             * comment
             */


            // 출력
            Console.Write("이건 안개행");
            Console.Write("입니다.");
            Console.WriteLine();
            Console.WriteLine("이건 개행");
            Console.WriteLine("입니다.");

            Console.WriteLine();

            // 자료형 (Data Type)
            // Integer
            Console.WriteLine(53 + 272 - 123);  // 202
            Console.WriteLine(53 * 3 - 3);      // 156
            Console.WriteLine(14 / 2);          // 7
            Console.WriteLine(14 / 3);          // 4
            Console.WriteLine(14 % 3);          // 2
            // Real Number
            Console.WriteLine(13.123);
            Console.WriteLine(0);               // 0과 0.0은 다름
            Console.WriteLine(0.0);
            Console.WriteLine(14.0 / 2.0);      // 7.0
            Console.WriteLine(14.0 / 3.0);      // 4.66666667
            Console.WriteLine(14 / 3);          // 4
            Console.WriteLine(14.0 / 3);        // 4.66666667
            Console.WriteLine(14 / 3.0);        // 4.66666667
            Console.WriteLine(14.0 / 3.0);      // 4.66666667

            // Character
            Console.WriteLine('A');             // 문자
            // String
            Console.WriteLine("A");             // 문자열
            // Escape  Character
            Console.WriteLine("\t 탭 \\ 역슬래시 \n 개행 \" 큰따옴표");
            Console.WriteLine("미\t림여자정보과학고");
            Console.WriteLine("미림\t여자정보과학고");
            Console.WriteLine("미림여\t자정보과학고");
            Console.WriteLine("미림여자\t정보과학고");
            Console.WriteLine("미림여자정\t보과학고");
            Console.WriteLine("미림여자정보\t과학고");
            Console.WriteLine("미림여자정보과\t학고");
            Console.WriteLine("미림여자정보과학\t고");
        }
    }
}
