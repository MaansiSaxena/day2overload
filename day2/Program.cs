using System;

namespace day2
{
    public class overloading
    {
        public static int sub2(int one, int two)
        {
            Console.Write("sub of two numbers ");
            return one - two;
        }
        public static int multi3(int one, int two, int three)
        {
            Console.WriteLine("multiplication of 3 no. ");
            return one * two * three;
        }
        public static string concatinate(string one, string two, string three, string four)
        {
            Console.WriteLine("string after concatenation");
            return one + two + three + four;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(overloading.sub2(3, 1));
            Console.WriteLine(overloading.multi3(1, 2, 3));
            Console.WriteLine(overloading.concatinate("4", "9", "3", "8"));
        }
    }
}
