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
            Console.WriteLine("Hello"  + Username + "welcome to Spark"); //printing hello with the username


            Console.WriteLine("please enter your age: ");
            int age = int.Parse(Console.ReadLine()); //using int.parse to convert the string input to an integer

            Console.WriteLine("enter your salary: ");
            float salary = float.Parse(Console.ReadLine()); //using float.parse to convert the string input to a float




            Console.WriteLine("enter first number: ");
            float num1 = float.Parse(Console.ReadLine()); 

            Console.WriteLine("enter second number: ");
            float num2 = float.Parse(Console.ReadLine());

            float sum = num1 + num2; //adding the two numbers
            float difference = num1 - num2; //subtracting the two numbers
            float multiplication = num1 * num2; //multiplying the two numbers
            float division = num1 / num2; //dividing the two numbers
            float modulus = num1 % num2; //modulus of the two numbers

            Console.WriteLine("The sum of the two numbers is: " + sum);
            Console.WriteLine("The difference of the two numbers is: " + difference);
            Console.WriteLine("The product of the two numbers is: " + multiplication);
            Console.WriteLine("The quotient of the two numbers is: " + division);
            Console.WriteLine("The modulus of the two numbers is: " + modulus);

        }



    }
}
