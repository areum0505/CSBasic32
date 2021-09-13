using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSBasic10
{
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
    class Program
    {
        public static void TestMethod()
        {
            for(int i = 0; i < 1000; i++)
            {
                Console.Write("A");
            }
        }
        public delegate void SendString(string message);

        public static void Hello(string message)
        {
            Console.WriteLine("안녕하세요 " + message + "씨");
        }
        public static void GoodBye(string message)
        {
            Console.WriteLine("안녕히가세요 " + message + "씨");
        }
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product() {Name="감자", Price=500},
                new Product() {Name="사과", Price=700},
                new Product() {Name="고구마", Price=400},
                new Product() {Name="배추", Price=600},
                new Product() {Name="상추", Price=300},
            };
            // 정렬
            //products.Sort(SortWithPrice); // 메서드이름 델리게이터
            /*products.Sort(delegate (Product x, Product y)   // 무명 델리게이터
            {
                return x.Price.CompareTo(y.Price);
            });*/
            /*products.Sort((x, y) =>     // 람다
            {
                return x.Price.CompareTo(y.Price);
            });*/
            products.Sort((x, y) => x.Price.CompareTo(y.Price));    //람다 한 줄
            // 출력
            foreach (var item in products)
            {
                Console.WriteLine(item.Name + " : " + item.Price);
            }

            Console.WriteLine();

            //delegate
            SendString sayHello, sayGoodbye, multiDelegate;
            sayHello = Hello;
            sayGoodbye = GoodBye;
            multiDelegate = sayHello + sayGoodbye;
            multiDelegate("윤인성");
            multiDelegate -= sayGoodbye;
            multiDelegate("윤인성");
            multiDelegate += sayHello;
            multiDelegate("윤인성");

            Console.WriteLine();

            // thread
            Thread threadA = new Thread(TestMethod);
            Thread threadB = new Thread(delegate() {
                for(int i=0; i < 1000;i++)
                {
                    Console.Write("B");
                }
            });
            Thread threadC = new Thread(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.Write("C");
                }
            });
            threadA.Start();
            threadB.Start();
            threadC.Start();
        }

        /* private static int SortWithPrice(Product x, Product y)
         {
             return x.Price.CompareTo(y.Price);
         }*/
    }
}
