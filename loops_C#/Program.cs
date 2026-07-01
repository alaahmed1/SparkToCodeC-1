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
            
        }
    }
}
