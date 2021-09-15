﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSBasic11
{
    class Program
    {
        class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public override string ToString()
            {
                return Name + " : " + Price + "원";
            }
        }
        static void Main(string[] args)
        {
            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> output1 = new List<int>();
            List<int> output2 = new List<int>();
            foreach (var item in input)
            {
                if(item % 2 == 0)
                {
                    output1.Add(item);
                }
            }
            foreach (var item in output1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            // Linq
            output2 = (from item in input
                       where item % 2 == 0
                       orderby item descending
                       select item).ToList();
            foreach (var item in output2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine();

            // 익명객체
            var output3 = from item in input
                          where item % 2 == 0
                          select new
                          {
                              A = item * 2,
                              B = item * item,
                              C = 100
                          };
            foreach (var item in output3)
            {
                Console.WriteLine(item.A + " / " + item.B + " / " + item.C);
            }

            Console.WriteLine();

            // Linq 구문과 클래스 활용
            List<Product> products = new List<Product>()
            {
                   new Product() {Name="고구마", Price=1500},
                   new Product() {Name="사과", Price=2400},
                   new Product() {Name="바나나", Price=1000},
                   new Product() {Name="배", Price=3000},
                   new Product() {Name="감자", Price=1000},
                   new Product() {Name="토마토", Price=2000},
                   new Product() {Name="옥수수", Price=1500},
                   new Product() {Name="자두", Price=500},
            };
            var output4 = from item in products
                          where item.Price > 1500
                          orderby item.Name ascending
                          select item;
            foreach (var item in output4)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            // Linq 응용 예제
            string url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=1150061500";
            XElement xElement = XElement.Load(url);
            var xmlQuery = from item in xElement.Descendants("data")
                           select new
                           {
                               no = item.Attribute("seq").Value,
                               hour = item.Element("hour").Value,
                               day = item.Element("day").Value,
                               temp = item.Element("temp").Value,
                               wdkor = item.Element("wdKor").Value,
                               wfkor = item.Element("wfKor").Value,
                               tempMin = item.Element("tmn").Value,
                               tempMax = item.Element("tmx").Value
                           };
            foreach (var item in xmlQuery)
            {
                Console.Write(item.no + "\t" + item.hour + "\t" + item.day + "\t" + item.temp + "\t" + item.wdkor + "\t" + item.wfkor + "\t" + item.tempMin + "\t" + item.tempMax + "\n");
            }
        }
    }
}
