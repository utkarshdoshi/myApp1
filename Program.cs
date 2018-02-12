using System;

namespace myApp
{
    class Program
    {
        static string  echoMe(string str)
        {return str;}

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(""+echoMe("utkarsh."));
        }
    }
}
