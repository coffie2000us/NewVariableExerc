using System;

namespace VariablesExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string myCat = "Peace";
            int catAge = 5;
            char firstLetter = 'P';
            bool isBlack = true;
            double hisWeight = 8;
            decimal height = 9.1m;

            Console.WriteLine($"The name of my dog is {myCat}. He is about {catAge} years old " +
                $"and his first initial is {firstLetter}. It is {isBlack} that {myCat} is black. He is " +
                $"{hisWeight} lbs and has a height of {height} inches");
        }
    }
}
