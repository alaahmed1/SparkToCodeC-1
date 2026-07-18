namespace HotelManagementSystem { 

    static class Room
{
    public static int RoomNumber { get; set; }
    public static string RoomType { get; set; }
    public static double Price { get; set; }
    public static bool IsAvailable { get; set; }
    public static void DisplayRoom()
    {
        Console.WriteLine($"Room Number: {RoomNumber}");
        Console.WriteLine($"Room Type: {RoomType}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Is Available: {IsAvailable}");
    }

}

    static class Guest
    {
        public static string guestId { get; set; }
        public static string guestName { get; set; }
        public static int RoomNumber { get; set; }
        public static DateTime checkInDate { get; set; }
        public static int totalNights { get; set; }

        public static void DisplayGuest()
        {
            Console.WriteLine($"Name: {guestName}");
            Console.WriteLine($"Room Number: {RoomNumber}");
            Console.WriteLine($"Check in Date: {checkInDate}");
        }

        public static void CalculateTotalNights(DateTime checkInDate, DateTime checkOutDate)
        {
            totalNights = (checkOutDate - checkInDate).Days;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
