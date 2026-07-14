

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
        private string email { get; set; }
        int age { get; set; } //default private

        public void Register(string Email)
        {
            email = Email; // set the email to the private field
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
        public int StockQuantity { get; set; }

        public void sell(int quantity)
        {
            if (quantity <= StockQuantity)
            {
                StockQuantity -= quantity;
                Console.WriteLine($"{quantity} units of {ProductName} sold.");
            }
            else
            {
                Console.WriteLine("Insufficient stock.");
            }
        }

        public void Restock(int quantity)
        {
            StockQuantity += quantity;
            Console.WriteLine($"{quantity} units of {ProductName} restocked.");
        }

        public double GetInventoryValue()
        {
            PrintDetails();
            return Price * StockQuantity;
        }

        private void PrintDetails()
        {
            Console.WriteLine($"Product Name: {ProductName}, Price: {Price}, Stock Quality: {StockQuantity}");
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

        static Product product1 = new Product { ProductName = "Laptop", Price = 5.500, StockQuantity = 10 };
        static Product product2 = new Product { ProductName = "Wirless Mouse", Price = 15.750, StockQuantity = 50 };



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
                    case 1: ViewAccountDetails(); break;
                    case 2: UpdateStudentAddress(); break;
                    case 3: MakeDeposit(); break;
                    case 4: MakeWithdrawal(); break;
                    case 5: ViewProductDetails(); break;
                    case 6: RegisterStudent(); break;
                    case 7: CompareAccountBalances(); break;
                    case 8: RestockProduct(); break;
                    //case 9: TransferBetweenAccounts(); break;
                    //case 10: UpdateStudentGrade(); break;
                    //case 11: StudentReportCard(); break;
                    //case 12: AccountHealthStatus(); break;
                    //case 13: BulkSaleWithRevenue(); break;
                    //case 14: ScholarshipEligibilityCheck(); break;
                    //case 15: FullBalanceTopUpFlow(); break;
                    //case 16: QuickAccountOpening(); break;
                    //case 17: TotalStudentsCounter(); break;
                    //case 18: OverdrawnAccountCheck(); break;
                    //case 19: SetStudentSecurityPin(); break;
                    case 20:
                        Exit = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 20.");
                        break;


                }

                Console.WriteLine("press any key");
                Console.ReadKey();
                Console.Clear();
            }



        }


        //task 1: view account details
        static void ViewAccountDetails()
        {
            Console.WriteLine("Choose acc 1 or 2: ");
            int accChoice = Convert.ToInt32(Console.ReadLine());
            if (accChoice == 1)
            {
                B1.CheckBalance();
            }
            else if (accChoice == 2)
            {
                B2.CheckBalance();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select 1 or 2.");
            }
        }

        //Task 2: Update Student Address
        static void UpdateStudentAddress()
        {
            Console.WriteLine("Choose student 1 or 2: ");
            int choice = Convert.ToInt16(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("type in the new address: ");
                string newadd = Console.ReadLine();
                student1.Address = newadd;
                Console.WriteLine("Student" + student1.Name + "new address is: " + student1.Address);
            }
            else if (choice == 2)
            {
                Console.WriteLine("type in the new address: ");
                string newadd = Console.ReadLine();
                student2.Address = newadd;
                Console.WriteLine("Student " + student2.Name + "new address is: " + student2.Address);
            }
            else
            {
                Console.WriteLine("Invalid student choice.");
            }
        }

        //Task 3: Make a Deposit
        static void MakeDeposit()
        {
            Console.WriteLine("Choose acc 1 or 2: ");
            int accChoice = Convert.ToInt32(Console.ReadLine());
            int amount;
            if (accChoice == 1)
            {
                Console.WriteLine("Enter amount to deposit: ");
                amount = Convert.ToInt32(Console.ReadLine());
                B1.Deposit(amount);
                Console.WriteLine("Deposit successful. New balance: " + B1.Balance);
            }
            else if (accChoice == 2)
            {
                Console.WriteLine("Enter amount to deposit: ");
                amount = Convert.ToInt32(Console.ReadLine());
                B2.Deposit(amount);
                Console.WriteLine("Deposit successful. New balance: " + B2.Balance);
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select 1 or 2.");
            }
        }


        //Task 4: Make a Withdrawal
        static void MakeWithdrawal()
        {
            Console.WriteLine("Choose acc 1 or 2: ");
            int accChoice = Convert.ToInt32(Console.ReadLine());
            int amount;
            if (accChoice == 1)
            {
                Console.WriteLine("Enter amount to Withdraw: ");
                amount = Convert.ToInt32(Console.ReadLine());
                B1.Withdraw(amount);
                Console.WriteLine("Deposit successful. New balance: " + B1.Balance);
            }
            else if (accChoice == 2)
            {
                Console.WriteLine("Enter amount to Withdraw: ");
                amount = Convert.ToInt32(Console.ReadLine());
                B2.Withdraw(amount);
                Console.WriteLine("Deposit successful. New balance: " + B2.Balance);
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select 1 or 2.");
            }
        }


        //Task 5: View Product Details
        static void ViewProductDetails()
        {
            Console.WriteLine("Choose product 1 or 2: ");
            int prodChoice = Convert.ToInt32(Console.ReadLine());
            if (prodChoice == 1)
            {
                double inventoryValue = product1.GetInventoryValue();
                Console.WriteLine($"Inventory Value of {product1.ProductName}: {inventoryValue}");
            }
            else if (prodChoice == 2)
            {
                double inventoryValue = product2.GetInventoryValue();
                Console.WriteLine($"Inventory Value of {product2.ProductName}: {inventoryValue}");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select 1 or 2.");
            }

        }


        //Task 6: Register a Student
        static void RegisterStudent()
        {
            Console.WriteLine("Choose student 1 or 2: ");
            int choice = Convert.ToInt16(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Enter email to register: ");
                string email = Console.ReadLine();
                student1.Register(email);
                Console.WriteLine("Student " + student1.Name + " registered with email: " + email);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter email to register: ");
                string email = Console.ReadLine();
                student2.Register(email);
                Console.WriteLine("Student " + student2.Name + " registered with email: " + email);
            }
            else
            {
                Console.WriteLine("Invalid student choice.");
            }

        }

        //Task 7: Compare Two Account Balances
        static void CompareAccountBalances()
        {
            if (B1.Balance > B2.Balance)
            {
                Console.WriteLine(B1.HolderName + " Holds more mony with balance of: " + B1.Balance);

            }
            else if (B2.Balance > B1.Balance)
            {
                Console.WriteLine(B2.HolderName + "Holds more mony with balance of: " + B2.Balance);
            }
            else
            {
                Console.WriteLine("Both accounts have the same balance.");
            }
        }

        //Task 8: Restock Product & Stock Level Check
        static void RestockProduct()
        {
            Console.WriteLine("Pick a product 1 or 2: ");
            int pronum = Convert.ToInt32(Console.ReadLine());

            int amount;
            if (pronum == 1)
            {
                Console.WriteLine("enter the quantity you want to add to product 1: ");
                amount = Convert.ToInt32(Console.ReadLine());
                product1.Restock(amount);

                if (product1.StockQuantity < 10)
                {
                    Console.WriteLine("Low in Stock");

                }
                else if (product1.StockQuantity >= 10 && product1.StockQuantity<=49)
                {
                    Console.WriteLine("Moderate");
                }
                else
                {
                    Console.WriteLine("well stocked");
                }

            }
            else if (pronum == 2)
            {
                Console.WriteLine("enter the quantity you want to add to product 2: ");
                amount = Convert.ToInt32(Console.ReadLine());
                product2.Restock(amount);

                if (product2.StockQuantity < 10)
                {
                    Console.WriteLine("Low in Stock");

                }
                else if (product2.StockQuantity >= 10 && product2.StockQuantity <= 49)
                {
                    Console.WriteLine("Moderate");
                }
                else
                {
                    Console.WriteLine("well stocked");
                }
            }
            else
            {
                Console.WriteLine("invalid produc number please choose 1 or 2");
            }
        }

    }
}




