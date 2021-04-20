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
        }
    }
}
