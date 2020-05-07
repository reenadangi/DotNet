using System;
using System.Collections.Generic;

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
            // for(int i=0;i<10;i++){
            //     Console.WriteLine($"{i} Hello {name}" );
            //    Console.WriteLine(random.Next(2,100));
            // }
            // Create a Loop that prints all values from 1-255
            // fizzBuzz();
            // Console.WriteLine(evenOrOdd(23));
            printArray();
            printList();
        }
        static void printList(){
            List<string> dojos=new List<string>();
            dojos.Add("Reena");


            

        }
        static void printArray(){
            // Declaring an array of length 5, initialized by default to all zeroes
            int[] numArray = new int[5];
            // Declaring an array with pre-populated values
            // For Arrays initialized this way, the length is determined by the size of the given data
            int[] numArray2 = {1,2,3,4,6};
            int[] nums={1,2,34,22};
            int[] array3;
            array3 = new int[] {1,3,5,7,9};
            for(int i=0;i<nums.Length;i++){
               Console.WriteLine(nums[i]);
            }
            string[] dojos={"reena","lee","casendra"};
            foreach(string dojo in dojos) {
                Console.WriteLine(dojo);
            }

        }
        static string evenOrOdd(int num){
            if(num%2==0){
                return("even");
            }
            else{
                return("Odd"); 
            }

        }
        static void fizzBuzz(){
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
