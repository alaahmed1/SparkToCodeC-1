namespace task1_solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a starting number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int count = number; count >= 1; count--)
            {
                Console.WriteLine(count);
            }

            Console.WriteLine("Liftoff!");
        }
    }
}