using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic8
{
    class Program
    {
        class Parent { }
        class Child : Parent, IDisposable, IComparable
        {
            public int CompareTo(object obj)
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }
        class TestClass : IBasic
        {
            public int TestProperty 
            { 
                get => 0;
                set => value = 0; 
            }

            public int TestInstanceMethod()
            {
                return 0;
            }
        }
        class Dummy : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine("리소스가 해제되었습니다.");
            }
        }
        class Product : IComparable
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public int CompareTo(object obj)
            {
                return Price.CompareTo((obj as Product).Price);
            }

            public override string ToString()
            {
                return Name + " : " + Price + "원";
            }
        }
        static void Main(string[] args)
        {
            // IComparable
            List<Product> list = new List<Product>()
            {
                  new Product() { Name="고구마", Price=1500},
                  new Product() { Name="사과", Price=2400},
                  new Product() { Name="바나나", Price=1000},
                  new Product() { Name="배", Price=3000},
                  new Product() { Name="멜론", Price=15000},
            };
            list.Sort();
            //list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            // IDisposable
            using (Dummy d = new Dummy())
            {
                Console.WriteLine("뭔가 했습니다.");
            }

            Console.WriteLine();

            IBasic basic = new TestClass();
            basic.TestProperty = 3;

            Console.WriteLine();

            Child child = new Child();
            Parent childParent = new Child();
            IDisposable childDisposable = new Child();
            IComparable childComparable = new Child();

            Console.WriteLine();

            // 파일입출력
            File.WriteAllText(@"C:\Users\Mirim\Desktop\test.txt", "안녕하세요");
            Console.WriteLine(File.ReadAllText(@"C:\Users\Mirim\Desktop\test.txt"));

            using(StreamWriter writer = new StreamWriter(@"C:\Users\Mirim\Desktop\test2.txt"))
            {
                writer.WriteLine("안녕하세요");
                writer.WriteLine("StreamWriter");
                writer.WriteLine("사용");
                for (int i = 0; i < 10; i++)
                {
                    writer.WriteLine("반복문 - " + i);
                }
            }
            using(StreamReader reader = new StreamReader(@"C:\Users\Mirim\Desktop\test2.txt"))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
