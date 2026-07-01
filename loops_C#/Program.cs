namespace loops_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //loops are used to execute a block of code repeatedly until a certain condition is met. There are different types of loops in C# such as for loop, while loop, and do-while loop.
            //1st type is for loop -->countable
            //2nd type is while loop--> uncountable

            //for loop logic/syntax:
            // for (start; end ; increment/decrement)
            //{
            //code to be executed
            //}


            int counter = 0; 
            for (counter=1; counter<=5; counter++) // repeating the sentance 5 times
            {
                Console.WriteLine("Hello, SparktoCode!" + counter);
            }
            

            bool exitDecision = false; //variable to store the decision of the user to exit the loop or not
            while (exitDecision == false) { // as long as the var equals to false this loop will run
                Console.WriteLine("print menu");
                Console.WriteLine("do you want to exit the loop? (y/n)");
                string userInput = Console.ReadLine(); //taking input from the user
                if (userInput == "y") //if the user input is y then the loop will exit
                {
                    exitDecision = true; //changing the value of the variable to true so that the loop will exit
                } //we dont need to use else statement here because if the user input is not y then the loop will continue to run
            }
        }
    }
}
