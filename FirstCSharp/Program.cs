using System;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello My World!");
            Random random=new Random();
            string name="Dojo";
            Console.WriteLine("Hello"+ 1.23 );
            Console.WriteLine($"My name is {0}, I am " + 28 + " years old", "Tim");
            Console.WriteLine("My name is {0}, I am " + 28 + " years old", "Tim"); 
            for(int i=0;i<10;i++){
                Console.WriteLine($"{i} Hello {name}" );
               Console.WriteLine(random.Next(2,100));
            }
            // Create a Loop that prints all values from 1-255
            for(int i=1;i<=100;i++){
                if(i%3==0 && i%5==0){
                    Console.WriteLine($"{i}FizzBuzz");
                }
                else{
                    if(i%3==0){
                        Console.WriteLine($"{i}fizz");
                    }
                    if(i%5==0){
                        Console.WriteLine($"{i}buzz");
                    }
                }
               
            }
            
            
        }
    }
}
