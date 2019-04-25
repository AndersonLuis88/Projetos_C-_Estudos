using System;
using Extension_Method.Extensions;


namespace Extension_Method
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime dt = new DateTime(2019, 03, 25, 11, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
                             
        }
    }
}
