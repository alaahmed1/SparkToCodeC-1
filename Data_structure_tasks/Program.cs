namespace Data_structure_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //an array is a data structure that can hold a fixed number of values of a single type. The values are stored in contiguous memory locations and can be accessed using an index. Arrays are useful when you need to store a collection of related data, such as a list of numbers or names.
            //Task 1: Fixed Grades Array
            //int[] grades = new int[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("Enter grade " + (i + 1) + ": ");
            //    grades[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //foreach (int grade in grades)
            //{
            //    Console.WriteLine(grade);
            //}


            // lists are a data structure that can hold a variable number of values of a single type.
            // The values are stored in non-contiguous memory locations and can be accessed using an index.
            // Lists are useful when you need to store a collection of related data that may change in size.
            //Task 2: Dynamic To-Do List
            //List <string> list = new List<string>(); //declare list to hold to do tasks
            //do
            //{
            //    Console.WriteLine("Enter a task to add to your to-do list (or type 'exit' to finish):");
            //    string task = Console.ReadLine();
            //    if (task.ToLower() != "exit")
            //    {
            //        list.Add(task); //add the task to the list
            //    }
            //} while (true);

            // Task 3: Stack to store browser history
            //Stack<string> history = new Stack<string>();
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write("Enter website URL " + (i + 1) + ": ");
            //    string url = Console.ReadLine();

            //    history.Push(url);
            //}
            //string previousPage = history.Pop(); // Simulate pressing the back button once

            //Console.WriteLine("You pressed the back button.");
            //Console.WriteLine("You are now on: " + history.Peek());


            // Task 4: Customer Service Queue
            //Queue<string> customers = new Queue<string>();
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write("Enter customer name " + (i + 1) + ": ");
            //    string name = Console.ReadLine();

            //    customers.Enqueue(name);
            //}

            
            //string servedCustomer = customers.Dequeue(); //getting the first customer in the queue and removing it from the queue

            //Console.WriteLine("\nCustomer served: " + servedCustomer);



        }
    }
}
