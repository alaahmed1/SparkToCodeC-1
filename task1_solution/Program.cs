namespace task1_solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////task 1: Countdown Timer
            //Console.Write("Enter a starting number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //for (int count = number; count >= 1; count--)
            //{
            //    Console.WriteLine(count);
            //}

            //Console.WriteLine("Liftoff!");


            //task 2:
            Console.WriteLine("enter a positive whole number:");
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int count = 0; count <= N; count++)
            {
                sum += count;
            }
            Console.WriteLine("the sum of numbers from 0 to N is: " + sum);

        }
    }
}