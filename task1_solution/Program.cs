namespace task1_solution
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task 1: Count down 
            Console.Write("enter a number to count down from: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int count = number; count >= 1; count--) {

                Console.WriteLine(count);
            }

            Console.WriteLine("Liftoff!");

        }
    }
}
