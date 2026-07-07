namespace User_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1: Personalized Welcome Function
            //Console.Write("write your name: ");
            //string userName = Console.ReadLine();
            //PrintWelcome(userName);


            //Task 2: Sqaure number Function
            //Console.Write("enter a number to calculate its square: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("the square of the number is: " + Square(number));

            //Task 4: Display Menu
            DisplayMenu();

        }
        //static void PrintWelcome(string name) // Personalized Welcome Function
        //{
        //    Console.WriteLine("Welcome " + name);
        //}

        //static int Square(int number) //Sqaure number Function
        //{
        //    int result = number * number;
        //    return result;
        //}

        static void DisplayMenu() //task 4
        {
            Console.WriteLine("menu");
            Console.WriteLine("1) Start");
            Console.WriteLine("2) Help");
            Console.WriteLine("3) Exit");
        }
    }
}
