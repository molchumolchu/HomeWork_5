using System;

namespace MyMethods

{
    public static class MyMethodsClass
    {
        public static int Input(string text)
        {
            Console.WriteLine(text);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}