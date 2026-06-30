namespace CSharpdFirstProject //name of the project
{
    internal class Program
    {
        //This section contains the main code of the program
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, SparktoCode!");

            //taking user info
            Console.Write("Please enter your name: ");
            String Username = Console.ReadLine();
            Console.WriteLine("Hello" + Username + "welcome to Spark"); //printing hello with the username


            Console.WriteLine("please enter your age: ");
            int age = int.Parse(Console.ReadLine()); //using int.parse to convert the string input to an integer

            Console.WriteLine("enter your salary: ");
            float salary = float.Parse(Console.ReadLine()); //using float.parse to convert the string input to a float



            //taking 2 numbers from the user and performing arithmetic operations on them
            Console.WriteLine("enter first number: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("enter second number: ");
            float num2 = float.Parse(Console.ReadLine());

            float sum = num1 + num2; //adding the two numbers
            float difference = num1 - num2; //subtracting the two numbers
            float multiplication = num1 * num2; //multiplying the two numbers
            float division = num1 / num2; //dividing the two numbers
            float modulus = num1 % num2; //modulus of the two numbers

            //outputting the results of the arithmetic operations
            Console.WriteLine("The sum of the two numbers is: " + sum);
            Console.WriteLine("The difference of the two numbers is: " + difference);
            Console.WriteLine("The product of the two numbers is: " + multiplication);
            Console.WriteLine("The quotient of the two numbers is: " + division);
            Console.WriteLine("The modulus of the two numbers is: " + modulus);


            bool result = num1 > num2; //checking if num1 is greater than num2
            bool result1 = num1 < num2; //checking if num1 is less than num2
            bool result2 = num1 == num2; //checking if num1 is equal to num2

            Console.WriteLine("Comparison results: ");
            Console.WriteLine("Is num1 greater than num2? " + result);
            Console.WriteLine("Is num1 less than num2? " + result1);
            Console.WriteLine("Is num1 equal to num2? " + result2);

            // conditional statements (and-->&&, or-->||, not-->!)
            //degree input scenario
            Console.WriteLine("Please enter your degree: ");
            float degree = float.Parse(Console.ReadLine());

            if (degree > 50)
            {
                Console.WriteLine("You failed");
            }
            else if(degree >= 50 && degree < 60)
            {
                Console.WriteLine("You passed with level D");
            }
            else if (degree >= 60 && degree < 70)
            {
                Console.WriteLine("You passed with level C");
            }
            else if (degree >= 70 && degree < 80)
            {
                Console.WriteLine("You passed with level B");
            }
            else if (degree >= 80 && degree < 90)
            {
                Console.WriteLine("You passed with level A");
            }
            else if (degree >= 90 && degree <= 100)
            {
                Console.WriteLine("You passed with level A+");
            }
            else
            {
                Console.WriteLine("Invalid degree input");
            }


            //switch case example for bank menu
            Console.WriteLine("Welcome to main menu");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");

            Console.WriteLine("Please select an option: ");
            int option = int.Parse(Console.ReadLine());


        }

    }
}
