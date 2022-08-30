using System;

namespace SyntaxSugarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
           var answer = 4;

           var response = (answer < 9) ? "is less than nine." : "greater than or equal to nine.";

            Console.WriteLine($"The response you got back is: {response}");
        }
    }
}
