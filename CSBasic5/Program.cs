using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic5
{
    class Box
    {
        private int width;
        public int Width
        {
            get { return width; }
            set {
                if (value > 0)
                    width = value;
                else
                    Console.WriteLine("양수만 입력 가능");
            }
        }
        private int height;
        public int Hieght { get; set; } // prop

        /*private int myVar;    // propfull
        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }*/



        public Box(int width, int height)
        {
            if (width > 0 && height > 0)
            {
                this.width = width;
                this.height = height;
            }
            else
            {
                Console.WriteLine("음수");
            }
        }

        public int Area
        {
            get { return this.width * this.height; }
        }
    }

    class Product
    {
        public static int counter = 0;
        public readonly int id;
        public string name;
        public int price;

        public Product(string name, int price)
        {
            counter++;
            this.id = counter;
            this.name = name;
            this.price = price;
        }

        // 프로그램이 종료될 때
        ~Product()
        {
            Console.WriteLine(this.name + "의 소멸자 호출");
        }

        public override string ToString()
        {
            return id + " : " + name + "(" + price + "원)";
        }
    }

    // ----------------------------------- 정적 생성자
    class Sample
    {
        public static int value;
        static Sample()
        {
            value = 10;
            Console.WriteLine("정적 생성자 호출");
        }
    }

    class Program
    {
        int someModifier = 0;   // private

        public int instanceVariable = 10;
        public int instanceMethod()
        {
            return 0;
        }

        class MyMath
        {
            public static int Abs(int input)
            {
                return (input < 0 ? -input : input);
            }
            public static double Abs(double input)
            {
                return (input < 0 ? -input : input);
            }
            public static long Abs(long input)
            {
                return (input < 0 ? -input : input);
            }
        }

        class Test
        {
            public void TestMethod()
            {
                Program.Main(new string[] { "" });
            }
            // Method Signature
            public int Sum(int min, int max)
            {
                int output = 0;
                for (int i = 0; i <= max; i++)
                {
                    output += i;
                }
                return output;
            }
        }

        class MethodExample
        {
            public int Power(int x)
            {
                return x * x;
            }
            public int Multi(int x, int y)
            {
                return x * y;
            }
            public void Print()
            {
                Console.WriteLine("Print() 메서드 호출됨");
            }
        }

        static void Main(string[] args)
        {
            MethodExample me = new MethodExample();
            Console.WriteLine(me.Power(10));
            Console.WriteLine(me.Power(20));
            Console.WriteLine(me.Multi(52, 273));
            Console.WriteLine(me.Multi(103, 32));
            me.Print();

            Console.WriteLine();

            Test test = new Test();
            Console.WriteLine(test.Sum(1, 100));

            Console.WriteLine();

            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-52));

            Console.WriteLine();

            // 클래스메서드에서는 인스턴스 변수, 메서드 접근 불가
            // 객체를 만들어 접근해야한다.
            //Console.WriteLine(instanceVariable);
            //instanceMethod();
            Program p = new Program();
            Console.WriteLine(p.instanceVariable);
            Console.WriteLine(p.instanceMethod());

            Console.WriteLine();

            // 오버로딩
            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-273));
            Console.WriteLine(MyMath.Abs(52.073));
            Console.WriteLine(MyMath.Abs(299999999999));

            Console.WriteLine();

            Product productA = new Product("감자", 2000);
            Product productB = new Product("고구마", 3000);
            Product productC = new Product("옥수수", 4000);
            //Console.WriteLine(productA.id + " : " + productA.name);
            Console.WriteLine(productA.ToString());
            Console.WriteLine(productB.ToString());
            Console.WriteLine(productC.ToString());
            Console.WriteLine(Product.counter + "개 생성되었습니다.");

            Console.WriteLine();

            // 정적생성자는 처음 로드될 때 딱 한 번 호출됨
            Console.WriteLine("첫 번째 위치");
            Console.WriteLine(Sample.value);
            Console.WriteLine("두 번째 위치");
            Sample sample = new Sample();
            Console.WriteLine("세 번째 위치");

            Console.WriteLine();

            Box box = new Box(10, 200);
            Console.WriteLine(box.Area);
            Box wrongbox = new Box(-10, -5);
            Console.WriteLine(wrongbox.Area);

            Console.WriteLine();

            int a = 10;
            Change(a);
            Console.WriteLine(a);

            Console.WriteLine();

            TestSome t = new TestSome();
            t.value = 30;
            TestSome.Change(t);
            Console.WriteLine(t.value);

            Console.WriteLine();
        }

        static void Change(int input)
        {
            input = 20;
        }
    }

    class TestSome
    {
        public int value = 10;

        public static void Change(TestSome input)
        {
            input.value = 20;
        }
    }
}
