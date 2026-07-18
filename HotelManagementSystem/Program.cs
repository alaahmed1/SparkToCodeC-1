using System; //to use Console.WriteLine and other console methods
using System.Linq; //to use LINQ methods like FirstOrDefault and Any
using System.Collections.Generic; //to use List<T> and other collection types

namespace HotelManagementSystem
{

    public class Room
    {
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public double PricePerNight { get; set; }
        public bool IsAvailable { get; set; }
        public void DisplayRoom()
        {
            Console.WriteLine($"Room Number: {RoomNumber}");
            Console.WriteLine($"Room Type: {RoomType}");
            Console.WriteLine($"Price: {PricePerNight}");
            Console.WriteLine($"Is Available: {IsAvailable}");
        }

    }

    class Guest
    {
        public string GuestId { get; set; }
        public string GuestName { get; set; }
        public string RoomNumber { get; set; } //not assigned yet, will be assigned when booking a room
        public DateTime checkInDate { get; set; }
        public int totalNights { get; set; }

        public void DisplayGuest()
        {
            Console.WriteLine($"Name: {GuestName}");
            Console.WriteLine($"Room Number: {RoomNumber}");
            Console.WriteLine($"Check in Date: {checkInDate}");
        }

        

        public int CalculateTotalCost(double pricePerNight)
        {
            return (int)(totalNights * pricePerNight);
        }
    }


    internal class Program
    {
        static List<Room> rooms = new List<Room>(); //defining a new list of rooms based on the class Room
        static List<Guest> guests = new List<Guest>(); // static so it can be accessed 


        static void Main(string[] args)
        {
            // Adding some sample rooms to the list
            rooms.Add(new Room { RoomNumber = 101, RoomType = "Single", PricePerNight = 100, IsAvailable = true });
            rooms.Add(new Room { RoomNumber = 102, RoomType = "Double", PricePerNight = 150, IsAvailable = true });
            rooms.Add(new Room { RoomNumber = 103, RoomType = "Suite", PricePerNight = 200, IsAvailable = true });
            rooms.Add(new Room { RoomNumber = 104, RoomType = "Single", PricePerNight = 100, IsAvailable = true });
            rooms.Add(new Room { RoomNumber = 105, RoomType = "Double", PricePerNight = 150, IsAvailable = true });
            rooms.Add(new Room { RoomNumber = 106, RoomType = "Suite", PricePerNight = 200, IsAvailable = true });

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
                    case 2:
                        RegisterNewGuest();
                        break;
                    case 3:
                        BookAroom();
                        break;
                    case 4:
                        ViewAllRooms();
                        break;
                    //case "5": 
                    //    ViewAllGuests(); 
                    //    break;
                    //case "6": 
                    //    SearchAndFilterRooms(); 
                    //    break;
                    //case "7": 
                    //    GuestAndBookingStatistics(); 
                    //    break;
                    //case "8": 
                    //    UpdateRoomPrice();
                    //    break;
                    //case "9": 
                    //    GuestLookupByName();
                    //    break;
                    //case "10": 
                    //    RoomTypeBreakdownReport(); 
                    //    break;
                    //case "11": 
                    //    CheckOutGuest();
                    //    break;
                    //case "12": 
                    //    RemoveUnavailableRooms(); 
                    //    break;
                    //case "13": 
                    //    ExtendGuestStay(); 
                    //    break;
                    //case "14": 
                    //    HighestRevenueBooking(); 
                    //    break;
                    //case "15": 
                    //    GuestPaginationViewer();
                    //break;
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
            else
            {
                Room newRoom = new Room { RoomNumber = roomNumber, RoomType = roomType, PricePerNight = price, IsAvailable = true };
                rooms.Add(newRoom);
            }

            Console.WriteLine("Room added successfully!");
        }

        static void RegisterNewGuest() //Task 2: Register New Guest
        {
            Console.Write("Enter Guest Name: ");
            string guestName = Console.ReadLine();
            Console.Write("Enter Check-In Date (MM/dd/yyyy): ");
            DateTime CheckInDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter Total Nights: ");
            int TotalNights;

            try
            {
                TotalNights = Convert.ToInt32(Console.ReadLine());
                if (TotalNights <= 0)
                {
                    Console.WriteLine("Total nights must be greater than 0.");
                    return;
                }
            }
            catch (Exception ex) {
                 Console.WriteLine(ex.Message);
                return;
            }
            string guestId = $"G{(guests.Count + 1):D3}"; // Generate a unique guest ID based on the count of guests in format G001, G002, etc.
            Guest newGuest = new Guest { GuestId = guestId, GuestName = guestName, checkInDate = CheckInDate, totalNights = TotalNights };
            guests.Add(newGuest);
            Console.WriteLine($"Guest registered successfully! Guest ID is {newGuest.GuestId}");
        }


        static void BookAroom()
        {
            Console.Write("Enter Guest ID: ");
            string guestId = Console.ReadLine();

            Console.Write("Enter Room Number: ");

            int roomNumber;

            try
            {
                roomNumber = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid room number.");
                return;
            }

            // Find guest
            Guest selectedGuest = guests.FirstOrDefault(g => g.GuestId == guestId);

            if (selectedGuest == null)
            {
                Console.WriteLine("Guest not found.");
                return;
            }

            // Find room
            Room selectedRoom = rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);

            if (selectedRoom == null)
            {
                Console.WriteLine("Room not found.");
                return;
            }

            // Check availability
            if (!selectedRoom.IsAvailable)
            {
                Console.WriteLine("Room is already booked.");
                return;
            }


            // Update objects
            selectedGuest.RoomNumber = roomNumber.ToString();
            selectedRoom.IsAvailable = false;


            // Calculate cost
            double totalCost = selectedGuest.CalculateTotalCost(selectedRoom.PricePerNight);


            // Confirmation
            Console.WriteLine("\n===== Booking Confirmation =====");
            Console.WriteLine($"Guest Name: {selectedGuest.GuestName}");
            Console.WriteLine($"Room Number: {selectedRoom.RoomNumber}");
            Console.WriteLine($"Room Type: {selectedRoom.RoomType}");
            Console.WriteLine($"Price Per Night: {selectedRoom.PricePerNight}");
            Console.WriteLine($"Total Nights: {selectedGuest.totalNights}");
            Console.WriteLine($"Total Cost: {totalCost}");
        }



        static void ViewAllRooms()
        {  //Task 4: view all rooms
            
            var orderedRooms = rooms.OrderBy(r => r.RoomNumber).ToList();
            if (orderedRooms.Count == 0)
            {
                Console.WriteLine("No rooms available.");
                return;
            }
            Console.WriteLine($"Total rooms: {orderedRooms.Count()}\n");
            foreach (Room rooms in orderedRooms)
            {
                rooms.DisplayRoom();
            }
        }
        




    }
}
