using System;

namespace PlayingWithVariablesConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Fido";
            int dogAge = 3;
            Char initial = 'f';
            bool KnowsTricks = true;
            double height = 2.5;
            decimal weight = 36m;

            Console.WriteLine($"My dog's Name is {dogName}. He is {dogAge} years old. it's {initial}. it's {KnowsTricks}");
            Console.WriteLine($"He is{height} feet tall and weighs {weight} pounds");


        }
    