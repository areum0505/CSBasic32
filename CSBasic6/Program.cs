using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic6
{
    class Program
    {
       
        class Animal
        {
            public void Eat()
            {
                Console.WriteLine("냠냠");
            }
            public virtual void Eat2()
            {
                Console.WriteLine("냠냠");
            }
        }
        class Cat : Animal
        {
            public new void Eat()
            {
                Console.WriteLine("야옹");
            }
            public override void Eat2()
            {
                Console.WriteLine("야옹");
            }
        }
        class Dog : Animal
        {
            public new void Eat() {
                Console.WriteLine("멍멍");
            }
            public override void Eat2()
            {
                Console.WriteLine("멍멍");
            }
        }

        class Parent
        {
            public int variable = 273;
            public void Method()    // 하이딩
            {
                Console.WriteLine("부모 메서드");
            }
            public virtual void Method2()   // 오버라이드
            {
                Console.WriteLine("부모 메서드");
            }
        }
        class Child : Parent
        {
            public new string variable = "hiding";
            public new void Method()
            {
                Console.WriteLine("자식 메서드");
            }
            public override void Method2()  
            {
                Console.WriteLine("자식 메서드");
            }
        }

        static void Main(string[] args)
        {
            Child child = new Child();
            Console.WriteLine(child.variable);
            Console.WriteLine(((Parent)child).variable);
            Console.WriteLine();

            child.Method();
            ((Parent)child).Method();
            Console.WriteLine();

            child.Method2();
            ((Parent)child).Method2();


            Console.WriteLine("---------------");


            List<Animal> animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Dog(), new Cat(),
                new Dog(), new Cat(), new Dog(), new Cat()
            };
            foreach (var item in animals)
            {
                item.Eat();
            }

            Console.WriteLine();

            List<Animal> animals2 = new List<Animal>()
            {
                new Dog(), new Cat(), new Dog(), new Cat(),
                new Dog(), new Cat(), new Dog(), new Cat()
            };
            foreach (var item in animals2)
            {
                item.Eat2();
            }

        }
    }
}
