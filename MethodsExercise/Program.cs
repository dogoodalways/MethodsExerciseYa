namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();
            Console.WriteLine($"Hello {name}, today {band} will be playing at Rogers Park. You can bring {animal} with you. Oh, remember to where a {color} sweater! See ya!");
        }
    }
}
