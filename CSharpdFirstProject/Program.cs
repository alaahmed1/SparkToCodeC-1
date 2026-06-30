namespace CSharpdFirstProject //name of the project
{
    internal class Program
    {
        //This section contains the main code of the program
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, SparktoCode!");

            Console.Write("Please enter your name: ");
            String Username = Console.ReadLine();
            Console.WriteLine("Hello"  + Username); //printing hello with the username


            Console.WriteLine("please enter your age: ");
            int age = int.Parse(Console.ReadLine()); //using int.parse to convert the string input to an integer
            Console.WriteLine("You are " + age + " years old.");

          
        }



    }
}
