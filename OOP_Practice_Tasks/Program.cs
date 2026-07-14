using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

namespace OOP_Practice_Tasks
{

    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        public void CheckBalance()
        {
            PrintInformation();
            Console.WriteLine(Balance);
        }

        private void PrintInformation()
        {
            Console.WriteLine($"Account Number: {AccountNumber}, Holder Name: {HolderName}, Balance: {Balance}");
        }

        private void SendEmailNotification(string message)
        {
            // Code to send email notification
        }
    }

    public class Student
    {
        public int Grade { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        private string Email { get; set; }
        int age { get; set; } //default private

        public void Register(string Email)
        {
            Email = Email; // set the email to the private field
            SendEmail("You have been registered successfully."); // call the private method to send a notification
        }

        private void SendEmail(string message)
        {
            // Code to send email notification
        }
    }


    public class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int StockQuality { get; set; }

        public void sell(int quantity)
        {
            if (quantity <= StockQuality)
            {
                StockQuality -= quantity;
                Console.WriteLine($"{quantity} units of {ProductName} sold.");
            }
            else
            {
                Console.WriteLine("Insufficient stock.");
            }
        }

        public void Restock(int quantity)
        {
            StockQuality += quantity;
            Console.WriteLine($"{quantity} units of {ProductName} restocked.");
        }

        public GetventoryValue()
        {
            PrintDetails();
            double inventoryValue = Price * StockQuality;
        }

        private void PrintDetails()
        {
            Console.WriteLine($"Product Name: {ProductName}, Price: {Price}, Stock Quality: {StockQuality}");
        }

        private void LogTransaction(string message)
        {
            // Code to log transaction details
        }

    }





    public class Program
    {
        //six objects
        static BankAccount B1 = new BankAccount { AccountNumber = 1163, HolderName = "Karim", Balance = 120 };
        static BankAccount B2 = new BankAccount { AccountNumber = 1164, HolderName = "Ahmed", Balance = 150 };

        static Student student1 = new Student { Name = "Ali", Address = "Muscat", Grade = 65 };
        static Student student2 = new Student { Name = "Sara", Address = "Salalah", Grade = 75 };

        static Product product1 = new Product { ProductName = "Laptop", Price = 5.500, StockQuality = 10 };
        static Product product2 = new Product { ProductName = "Wirless Mouse", Price = 15.750, StockQuality = 50};

        public static object Continue { get; private set; }

        static void Main(string[] args)
        {

            bool Exit = false;
            while (!Exit)
            {
                //print options to the user
                Console.WriteLine("\n===== OOP Part 1 - Bank / Student / Product Manager =====");
                Console.WriteLine(" 1. View Account Details");
                Console.WriteLine(" 2. Update Student Address");
                Console.WriteLine(" 3. Make a Deposit");
                Console.WriteLine(" 4. Make a Withdrawal");
                Console.WriteLine(" 5. View Product Details");
                Console.WriteLine(" 6. Register a Student");
                Console.WriteLine(" 7. Compare Two Account Balances");
                Console.WriteLine(" 8. Restock Product & Stock Level Check");
                Console.WriteLine(" 9. Transfer Between Accounts");
                Console.WriteLine("10. Update Student Grade (Validated)");
                Console.WriteLine("11. Student Report Card");
                Console.WriteLine("12. Account Health Status");
                Console.WriteLine("13. Bulk Sale With Revenue Calculation");
                Console.WriteLine("14. Scholarship Eligibility Check");
                Console.WriteLine("15. Full Balance Top-Up Flow");
                Console.WriteLine("16. Quick Account Opening (Parameterized Constructor)");
                Console.WriteLine("17. Total Students Counter (Static Field & Method)");
                Console.WriteLine("18. Overdrawn Account Check (Read-Only Property)");
                Console.WriteLine("19. Set Student Security PIN (Write-Only Property)");
                Console.WriteLine("20. Exit");
                Console.Write("Choose an option: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    continue;
                }

                switch (choice)
                {

                    //all choices and their respective methods to be called here
                    //lastly add choice to exit the program Exit = true; break;
                }
            }
            

            
        }
    }
}


// declare all the functions for the user to call

