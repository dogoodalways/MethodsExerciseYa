namespace MethodsExercise
{
    public class Program
    {
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        //public static int Sum(params int[] list)
        //{
        //    for(int i = 0; i< list.Length; i++)
        //    {

        //    }
        //}
        public static int Multiply(int num1, int num2, int num3) 
        {
            return num1 * num2 * num3; 
        }
        static void Main(string[] args)
        {
            //var amountOfCars = Sum(2, 6);
            //var blah = Multiply(7, 5, 4);
            //Console.WriteLine(amountOfCars + blah);

            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();
            //Console.WriteLine("What is your favorite color?");
            //string color = Console.ReadLine();
            //Console.WriteLine("What is your favorite animal?");
            //string animal = Console.ReadLine();
            //Console.WriteLine("What is your favorite band?");
            //string band = Console.ReadLine();
            //Console.WriteLine($"Hello {name}, today {band} will be playing at Rogers Park. You can bring {animal} with you. Oh, remember to where a {color} sweater! See ya!");

            //Console.WriteLine("how many cups of water did you drink today?");
            //int num1 =int.Parse(Console.ReadLine());

            //Console.WriteLine("how many cups of water will you drink today?");
            //int num2 = int.Parse(Console.ReadLine());

            //int sum = Sum(num1, num2);
            //Console.WriteLine($"you will drink {sum} cups of water today.");

            Console.WriteLine("how many cups of water do you drink each day?");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("how many days are in a week?");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("how weeks are in a month?");
            int num3 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2, num3);
            Console.WriteLine($"you will drink {product} cups of water this month.");


        }
    }
}
