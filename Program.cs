using System;

namespace myapp
{
    class Program
    {
        static string  echoMe(string str)
        {return str;}

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(""+echoMe("Finally, I have dockerized this 'hello world'. "));
            Console.WriteLine("Woohoo.... :)");
        }
    }
}
