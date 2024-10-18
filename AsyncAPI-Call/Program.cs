// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace Program001
{
    class Program {
        static void Main(string[] args){
            // string name = "leslie";

            // Console.Write to accept input on a single  line
            // Console.Write("Enter Your Name: ");
            // string username = Console.ReadLine();

            // Console.Write("Enter Your age: ");
            // int age = Convert.ToInt32(Console.ReadLine());


            // if( age < 0) {
            //     Console.WriteLine("Error in age ");
            // }
            // else if(age >= 18){
            //     Console.WriteLine($"{username} at {age} is allowed to vote");
            // }
            // else if(age < 18){
            //     Console.WriteLine($"{username} at {age} is NOT allowed to vote");
            // } 

        // grading system from 0 to 100
        Console.WriteLine("Welcome to the Grading System of RMU");
        Console.Write("Enter Your Grade For Testing: ");
        int score = Convert.ToInt32(Console.ReadLine());

        if(score > 100){
            Console.WriteLine($"{score} is more than accountable for");
        }
        else if(score <= 100 && score >= 90){
            Console.WriteLine($"Your {score} got you an A");
        }
        else if(score <= 89 && score >= 80 ){
            Console.WriteLine($"Your {score} got you an B");
        }
        else if(score <= 79 && score >= 70 ){
            Console.WriteLine($"Your {score} got you an c");
        }
        else if(score <= 69 && score >= 60 ){
            Console.WriteLine($"Your {score} got you an D");
        }
        else if(score <= 59 && score >= 50 ){
            Console.WriteLine($"Your {score} got you an E");
        }
        else if(score <= 49 && score >= 0 ){
            Console.WriteLine($"Your {score} got you an F");
        } 
        else if (score < 0){
            Console.WriteLine($"with this score {score} You owe you Lecturer marks");
        } 
        else {
            Console.WriteLine("Invalid Input");
        }

        

         
        }
    }
}