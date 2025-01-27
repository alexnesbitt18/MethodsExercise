﻿using System.Collections.Generic;

namespace MethodsExercise
{
    public class Program
    {
        private static int sum;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello there, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("Who is your favorite band of all time?");
            string band = Console.ReadLine();

            Console.WriteLine($"Once upon a time, there was a lovely person by the name of {name}.");
            Console.WriteLine($"One day, they woke up and put on their favorite shirt, since they always loved wearing the color {color}.");
            Console.WriteLine($"As they were walking a path as they normally do, they ran into peculiar {animal} who was singing.");
            Console.WriteLine($"They noticed right away that the {animal} was singing a song by their favorite band, {band}!");
            Console.WriteLine($"After a moment of hesitation, {name} joined in on the chorus and spent the rest of the day with the {animal}.");
            Console.WriteLine($"The End.");

            Console.WriteLine($"What number would you like to start with?");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"What second number would you like to add the first number with?");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum for these two numbers would be {sum}");

            Console.WriteLine($"What number would you like to start with?");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"What second number would you like to add the first number with?");
            int y = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The total for these two numbers would be {product}");

        }
        public static int Sum(params int[] list)
        { 
            for(int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }
            return sum;
        }
     
        public static int Subtraction(int num1, int num2)
        { 
            return num1 - num2;
        }
        public static int Multiply (int x, int y)
        {
            return x * y;
        }
        public static int Division (int x, int y)
        {
            return x / y;
        }
    }

}
