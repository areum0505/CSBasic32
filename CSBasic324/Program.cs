using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Car
{
    int carNumber;
    DateTime inTime;
    DateTime outTime;

    public void SetInTime()
    {
        this.inTime = DateTime.Now;
    }
    public void SetOutTime()
    {
        this.outTime = DateTime.Now;
    }
}
// class Math { }  -  x

class MyMath
{
    int sumenumber = 42;
    public static double PI = 3.141592;
    public static void Greeting()
    {
        // Console.WriteLine(somenumber); - 클래스 메서드에서 인스턴스 변수 접근 안됨 ( 반대는 가능)
        Console.WriteLine("Greeting!");
    }
}

namespace CSBasic324
{
    class FirstClass
    {

    }
    class SecondClass
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[10];

            // random
            Random random = new Random();
            Console.WriteLine(random.Next());
            Console.WriteLine(random.Next(100));        // 0 ~ 99   
            Console.WriteLine(random.Next(10, 100));    // 10 ~ 99
            Console.WriteLine(random.Next(1, 19));      // 1 ~ 18
            Console.WriteLine(random.NextDouble());     // 0부터 1미만
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());

            Console.WriteLine();

            // list
            /*            
            List<int> list = new List<int>();
            list.Add(52);
            list.Add(273);
            list.Add(32);
            list.Add(64);
            */
            List<int> list = new List<int>() { 52, 273, 32, 64 };
            foreach (var item in list)
            {
                Console.WriteLine("Count: " + list.Count + "\titem: " + item);
                // list.Remove(item); -- x
            }

            Console.WriteLine();

            // math
            Console.WriteLine(Math.Abs(-52222));        // 절댓값
            Console.WriteLine(Math.Ceiling(52.273));    // 올림
            Console.WriteLine(Math.Floor(52.273));      // 내림
            Console.WriteLine(Math.Round(52.273));      // 반올림
            Console.WriteLine(Math.Round(52.563));
            Console.WriteLine(Math.Max(52, 273));       // 큰 값
            Console.WriteLine(Math.Min(52, 273));       // 작은 값

            Console.WriteLine();

            // 클래스
            Product product = new Product();
            product.name = "감자";
            product.price = 2000;
            Console.WriteLine(product.name + " : " + product.price + "원");

            Product productA = new Product() { name = "짜장면", price = 5500 };
            Product productB = new Product() { name = "짬뽕", price = 8000 };
            Product productC = new Product() { name = "탕수육" };
            Product productD = new Product() { price = 999999 };
            Product productE = new Product() { price = 30000, name = "양장피" };


        }
    }
}
