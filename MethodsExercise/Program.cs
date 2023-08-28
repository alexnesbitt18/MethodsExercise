namespace MethodsExercise
{
    public class Program
    {
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


        }
    }
}
