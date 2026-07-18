using System;
using System.Collections.Generic;

namespace HotelManagementSystem { 

     class Room
{
        public  int RoomNumber { get; set; }
        public  string RoomType { get; set; }
        public  double Price { get; set; }
        public  bool IsAvailable { get; set; }
        public  void DisplayRoom()
    {
        Console.WriteLine($"Room Number: {RoomNumber}");
        Console.WriteLine($"Room Type: {RoomType}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Is Available: {IsAvailable}");
    }

}

     class Guest
    {
        public  string guestId { get; set; }
        public  string guestName { get; set; }
        public  int RoomNumber { get; set; }
        public  DateTime checkInDate { get; set; }
        public  int totalNights { get; set; }

        public void DisplayGuest()
        {
            Console.WriteLine($"Name: {guestName}");
            Console.WriteLine($"Room Number: {RoomNumber}");
            Console.WriteLine($"Check in Date: {checkInDate}");
        }

        //public int CalculateTotalNights( DateTime checkOutDate)
        //{
        //    totalNights = (checkOutDate - checkInDate).Days;
        //}
    }


    internal class Program
    {
        static List<Room> rooms = new List<Room>(); //defining a new list of rooms based on the class Room
        static List<Guest> guests = new List<Guest>(); // static so it can be accessed 

        
        static void Main(string[] args)
        {
            // Adding some sample rooms to the list
            rooms.Add(new Room { RoomNumber = 101, RoomType = "Single", Price = 100, IsAvailable = true });
            rooms.Add(new Room { RoomNumber = 102, RoomType = "Double", Price = 150, IsAvailable = true });
            rooms.Add(new Room { RoomNumber = 103, RoomType = "Suite", Price = 200, IsAvailable = true });
            rooms.Add(new Room { RoomNumber = 104, RoomType = "Single", Price = 100, IsAvailable = true });
            rooms.Add(new Room { RoomNumber = 105, RoomType = "Double", Price = 150, IsAvailable = true });
            rooms.Add(new Room { RoomNumber = 106, RoomType = "Suite", Price = 200, IsAvailable = true });

            Console.WriteLine("============================================");
            Console.WriteLine("Grand Hotel Management System ");
            Console.WriteLine("============================================");

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("1. Add New Room");
                Console.WriteLine("2. Register New Guest");
                Console.WriteLine("3. Book a Room for a Guest");
                Console.WriteLine("4. View All Rooms");
                Console.WriteLine("5. View All Guests");
                Console.WriteLine("6. Search & filter rooms");
                Console.WriteLine("7. Guest & Booking statistics");
                Console.WriteLine("8. Update Room Prices");
                Console.WriteLine("9. Guest Lookup by Name");
                Console.WriteLine("10. Room Type Breakdown Report");
                Console.WriteLine("11. Check Out a Guest");
                Console.WriteLine("12. Remove Unavailable Rooms");
                Console.WriteLine("13. Extend Guest Stay");
                Console.WriteLine("14. Highest Revenue Booking");
                Console.WriteLine("15. Guest Pagination Viewer");
                Console.WriteLine("16. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddNewRoon();
                        break;
                    //case 2:
                    //    BookRoom();
                    //    break;
                    //case 3:
                    //    CheckOut();
                    //    break;
                    case 16:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

         static void AddNewRoon() //Task 1: Add New Room
        {
            Console.Write("Enter Room Number: ");
            int roomNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Room Type: ");
            string roomType = Console.ReadLine();
            Console.Write("Enter Room Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            if (rooms.Any(r => r.RoomNumber == roomNumber))
            {
                Console.WriteLine("Room number already exists. Please try again.");
                return;
            }
            else {
                Room newRoom = new Room { RoomNumber = roomNumber, RoomType = roomType, Price = price, IsAvailable = true };
                rooms.Add(newRoom);
            }
            
            Console.WriteLine("Room added successfully!");
        }
    }
}
