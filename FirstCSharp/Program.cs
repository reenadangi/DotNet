using System;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello My World!");
            int i=0;
            string name="Dojo";
            while(i<10){
                Console.WriteLine($"{i} Hello {name}" );
                i++;
            }
        }
    }
}
