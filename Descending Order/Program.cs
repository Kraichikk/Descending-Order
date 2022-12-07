using System;
using System.Collections.Generic;
using System.Linq;

namespace Descending_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 123456789;
            Console.WriteLine(DescendingOrder(num));
        }
        //MySolution
        public static int DescendingOrder(int num)
        {
            string strNum = num.ToString();
            var list = strNum.ToList();

            list.Sort();
            list.Reverse();

            strNum = String.Join("", list);

            return Convert.ToInt32(strNum);
        }
        //more clever solution
        public static int DescendingOrder1(int num)
        {
            return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
        }
    }
}
