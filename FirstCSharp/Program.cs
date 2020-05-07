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
            printDict();
        }

        static void printDict(){
            Dictionary<string,string> profile=new Dictionary<string, string>();
            profile.Add("Name","Reena");
            profile.Add("Language","Python");
            profile.Add("location","Chicago");
            Console.WriteLine(profile["location"]);
            foreach(KeyValuePair<string,string> entry in profile){
                Console.WriteLine($"{entry.Key}-{entry.Value}" );
            }

        }
        static void printList(){
            List<string> dojos=new List<string>();
            dojos.Add("Reena");
            dojos.Add("Lee");
            dojos.Add("cass");
            dojos.Insert(2,"mike");
            dojos.Remove("Reena");
            foreach(string dojo in dojos){
                Console.WriteLine(dojo);
            }

        }
        static void printArray(){
            // Declaring an array of length 5, initialized by default to all zeroes
            int[] numArray = new int[5];
            // Declaring an array with pre-populated values
            // For Arrays initialized this way, the length is determined by the size of the given data
            int[] numArray2 = {1,2,3,4,6};
            int[] nums={1,2,34,22};
            
            int[,] arr2D=new int[3,3]{{2,4,6},{3,6,9},{4,8,12}};
            Console.WriteLine("2d array"+ arr2D[0,1]);


            int[] array3 = new int[] {1,3,5,7,9};
            for(int i=0;i<nums.Length;i++){
               Console.WriteLine(nums[i]);
            }
            string[] dojos={"reena","lee","casendra"};
            foreach(string dojo in dojos) {
                Console.WriteLine(dojo);
            }
            int[,] multi=new int[10,10];
            for(int i=1;i<=10;i++){
                for(int j=1;j<=10;j++){
                    multi[i-1,j-1]=i*j;
                }
            }
            Console.WriteLine(multi);
            for(int i=0;i<10;i++){
                 string str="[";
                 for(int j=0;j<10;j++){
                    str= str+ multi[i,j].ToString()+",";
                 }
                  str= str+"]";
                  Console.WriteLine(str);
            }
            foreach(int num in multi){
                Console.WriteLine("This is my table" +num);
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
