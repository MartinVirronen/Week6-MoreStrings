using System;

namespace AnotherStringToReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset "Hello, World!" tagurpidi
            Console.WriteLine("Type Hello World");

            string helloW = Console.ReadLine();

            

            for (int i = helloW.Length - 1; i >= 0; i--)
            {
                Console.Write(helloW[i]);
            }
               
           
        }

    }
}
