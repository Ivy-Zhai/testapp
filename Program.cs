using System;

namespace testapp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=5;
            if(a<1)
                Console.WriteLine("Hello World!");
            else
            {
                Console.WriteLine("This is my first C# program~");
                Console.Beep(1000,1000);
            }
        }
    }
}