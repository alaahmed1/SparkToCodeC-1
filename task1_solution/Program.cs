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


            //task 2: Sum of Numbers 1 to N
            //Console.WriteLine("enter a positive whole number:");
            //int N = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //for (int count = 0; count <= N; count++)
            //{
            //    sum += count;
            //}
            //Console.WriteLine("the sum of numbers from 0 to N is: " + sum);


            //Task3: Multiplication Table
            //Console.WriteLine("enter a number to print its multiplication table:");
            //int number = Convert.ToInt32(Console.ReadLine());
            //for (int count = 1; count <= 10; count++)
            //{
            //    int multi = number * count;
            //    Console.WriteLine(number + " x " + count + " = " + multi);
            //}

            //Task 4: Password Retry
            //string password = "Spark2026";
            //while (true)
            //{
            //    Console.Write("Enter the password: ");
            //    string input = Console.ReadLine();
            //    if (input == password)
            //    {
            //        Console.WriteLine("Access granted!");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Incorrect password. Please try again.");
            //    }
            //}


            //Task 5: Number Guessing Game
            //int secretNumber = 50;
            //int count = 0;
            //int gussed;
            //do
            //{
            //    Console.WriteLine("guess the seceret number");
            //    gussed = Convert.ToInt32(Console.ReadLine());
            //    //int numberattempts = +count; this does not work cuz count will always be 0 since it is not being incremented anywhere in the loop
            //    count++; // incrementing the count variable to keep track of the number of attempts
            //    Console.WriteLine("attempt " + count);

            //    if (gussed == secretNumber)
            //    {
            //        Console.WriteLine("you guessed the number");
            //        break;
            //    }
            //    else if (gussed < secretNumber)
            //    {
            //        Console.WriteLine("the number is too low");
            //    }
            //    else
            //    {
            //        Console.WriteLine("the number is too high");

            //    } 
            //} while(gussed != secretNumber) ;


            //Task 6: Safe Division Calculator
            Console.WriteLine("enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            try
            {
                float devide = num1 / num2;
                Console.WriteLine("the division of two numbers is: " + devide); 
            }

            catch (Exception e) // handling errors
            {
                Console.WriteLine(e.Message);
            }





        }

        
    }
}