namespace Built_in_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////task 1: Absolute Value of Difference
            //Console.Write("enter first number: ");
            //float firstNumber = Convert.ToSingle(Console.ReadLine());
            //Console.Write("enter second number: ");
            //float secondNumber = Convert.ToSingle(Console.ReadLine());
            //float sub = firstNumber - secondNumber;
            //Console.WriteLine("the absolute value of the difference between the two numbers is: " + Math.Abs(sub));


            //task 2: Power & Root Explorer
            //Console.WriteLine("enter a number to calculate its square and square root:");
            //int number = Convert.ToInt32(Console.ReadLine());
            //double square = Math.Pow(number, 2);
            //double squareRoot = Math.Sqrt(number);
            //Console.WriteLine("the square of the number is: " + square + " ,and the square root is: " + squareRoot);

            //task 3: Name Formatter
            //Console.Write("enter your full name: ");
            //string fullName = Console.ReadLine();
            //string UPPER = fullName.ToUpper();
            //string LOWER = fullName.ToLower();
            //int length = fullName.Length;
            //Console.WriteLine("your name in uppercase is: " + UPPER);
            //Console.WriteLine("your name in lowercase is: " + LOWER);
            //Console.WriteLine("the length of your name is: " + length);


            //task 4: Subscription End Date
            //Console.Write("enter number of day of free trial:");
            //int numDays = Convert.ToInt32(Console.ReadLine());
            //DateTime start = DateTime.Now;
            //DateTime end = start.AddDays(numDays);
            //Console.WriteLine("the end date of your free trial is: " + end.ToString("MM/dd/yyyy"));

            //task 5: Grade Rounding System
            //Console.Write("enter your grade as a decimal (e.g. 74.6): ");
            //double grade = Convert.ToDouble(Console.ReadLine());
            //double roundedGrade = Math.Round(grade, 0);
            //if (roundedGrade >= 60)
            //{
            //    Console.WriteLine("Passed with a grade of: " + roundedGrade);

            //}
            //else if (roundedGrade < 60)
            //{
            //    Console.WriteLine("Failed with a grade of: " + roundedGrade);
            //}

            //Task 6: Password Strength Checker
            //Console.WriteLine("enter a password to check its strength:");
            //string password = Console.ReadLine();
            //int length = password.Length;
            //bool passcontain = password.ToLower().Contains("password");

            //if (length>=8 && !passcontain)
            //{
            //    Console.WriteLine("strong password");

            //}
            //else
            //{
            //    Console.WriteLine("weak password");
            //}

            //Task 7: Clean Name Comparator
            //Console.Write("Enter the first name: ");
            //string name1 = Console.ReadLine().Trim().ToUpper();

            //Console.Write("Enter the second name: ");
            //string name2 = Console.ReadLine().Trim().ToUpper();

            //if (name1 == name2)
            //{
            //    Console.WriteLine("Match");
            //}
            //else
            //{
            //    Console.WriteLine("No Match");
            //}


            //Task 8: Membership Expiry Checker
            //Console.WriteLine("enter the membership start date (e.g. 2026-01-10):");
            //Console.WriteLine("enter number of valid membership days: ");
            //string inputDate = Console.ReadLine();
            //float validDays = Convert.ToSingle(Console.ReadLine());
            //DateTime start = DateTime.Parse(inputDate);
            //DateTime expiry = start.AddDays(validDays);
            //if (DateTime.Today >=  expiry)
            //{
            //    Console.WriteLine("Membership expired on: " + expiry.ToString("MM/dd/yyyy"));
            //}
            //else
            //{
            //    Console.WriteLine("Membership is valid until: " + expiry.ToString("MM/dd/yyyy"));
            //}

            //Task 9: Round Up / Round Down Explorer
            //Console.Write("Enter a decimal number: ");
            //double number = double.Parse(Console.ReadLine());
            //double nearest = Math.Round(number); // rounds to the nearest whole number
            //double roundedUp = Math.Ceiling(number);
            //double roundedDown = Math.Floor(number);
            //Console.WriteLine("Original number: " + number);
            //Console.WriteLine("Rounded to nearest whole number: " + nearest);
            //Console.WriteLine("Always rounded up: " + roundedUp);
            //Console.WriteLine("Always rounded down: " + roundedDown);


            //Task 10: Word Position Finder
            //Console.WriteLine("Enter a sentence:"); 
            //string sentence = Console.ReadLine();
            //Console.Write("Enter a word to search for: ");
            //string word = Console.ReadLine();

            //bool contains = sentence.Contains(word);
            //if (contains)
            //{
            //    // IndexOf returns the position of the FIRST occurrence of the word
            //    int firstPosition = sentence.IndexOf(word);
            //    // LastIndexOf returns the position of the LAST occurrence of the word
            //    int lastPosition = sentence.LastIndexOf(word);

            //    Console.WriteLine("Word found!");
            //    Console.WriteLine("First occurrence at position: " + firstPosition);
            //    Console.WriteLine("Last occurrence at position: " + lastPosition);
            //}
            //else
            //{
            //    // If Contains returns false, the word is not in the sentence at all
            //    Console.WriteLine("Word not found in the sentence.");
            //}




            //Task 11: OTP
            //Random random = new Random();
            //int otp = random.Next(1000, 9999);
            //Console.WriteLine("Generated OTP: " + otp);
            //Console.WriteLine("Please enter the OTP:");
            //for (int attempt = 1; attempt <= 3; attempt++)
            //{
            //    try
            //    {
            //        Console.WriteLine("Please enter the OTP:");
            //        int userInput = Convert.ToInt32(Console.ReadLine());
            //        if (userInput == otp)
            //        {
            //            Console.WriteLine("OTP verified successfully!");
            //        }

            //        else
            //        {
            //            throw new Exception("Invalid OTP. Please try again.");
            //        }


            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);

            //    }

            //    // After the third failed attempt
            //    if (attempt == 3)
            //    {
            //        Console.WriteLine("Verification Failed");
            //    }

            //}


            //Task 12: age calculator
            Console.WriteLine("Enter your date of birth (e.g., 1990-05-15):");
            string dobInput = Console.ReadLine();
            DateTime birthday = DateTime.Parse(dobInput);
            DateTime today = DateTime.Today;
            int age = today.Year - birthday.Year; // Calculate the initial age
                                                
            if (today.Month < birthday.Month || today.Month == birthday.Month && today.Day < birthday.Day)
            {
                age--; //subtract one year if the birthday hasn't occurred yet this year
            }

         
            Console.WriteLine("Age: " + age);
            Console.WriteLine("You were born on a " + birthday.DayOfWeek);

        }
    }
}
