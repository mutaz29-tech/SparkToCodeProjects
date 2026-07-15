using OOP_Task2;

namespace OOP_Task2
{
    //class Room
    internal class Room
    {
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public double PricePerNight { get; set; }
        public bool IsAvailable { get; set; }
        public Room(int roomNumber, string roomType, double pricePerNight, bool isAvailable)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            PricePerNight = pricePerNight;
            IsAvailable = isAvailable;
        }
        public void DisplayRoom()
        {
            Console.WriteLine("Room Number:" + RoomNumber);
            Console.WriteLine("Room Type:" + RoomType);
            Console.WriteLine("Price Per Night: " + PricePerNight);

            if (IsAvailable)
            {
                Console.WriteLine("Available");
            }
            else
            {
                Console.WriteLine("it is Booked");
            }
        }
    }

    //class Guest
    internal class Guest
    {
        public int GuestId { get; set; }
        public string GuestName { get; set; }
        public int RoomNumber { get; set; }
        public DateTime CheckInDate { get; set; }
        public int TotalNights { get; set; }

        public Guest(int guestId, string guestName, int roomNumber, DateTime checkInDate, int totalNights)
        {
            GuestId = guestId;
            GuestName = guestName;
            RoomNumber = roomNumber;
            CheckInDate = checkInDate;
            TotalNights = totalNights;
        }

        public void DisplayGuest()
        {
            Console.WriteLine("Guest Id:" + GuestId);
            Console.WriteLine("Guest Name:" + GuestName);
            Console.WriteLine("Room Number:" + RoomNumber);
            Console.WriteLine("Check In Date" + CheckInDate.ToShortDateString());
            Console.WriteLine("Total Nights:" + TotalNights);
        }

        public double CalculateTotalCost(List<Room> rooms) // Calculates based on room price and number of nights
        {
            foreach (Room room in rooms) //  Go through each room in the rooms list
            {
                if (room.RoomNumber == RoomNumber)
                {
                    return room.PricePerNight * TotalNights; // calculte cost Room price per night × number of nights stayed
                }
            }
            return 0; // if no matching rooms is found
        }
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        // Create a list to store all rooms
        List<Room> rooms = new List<Room>();

        // Create a list to store all guests
        List<Guest> guests = new List<Guest>();

        rooms.Add(new Room(101, "double", 20.00, true));
        rooms.Add(new Room(202, "single", 30, true));
        rooms.Add(new Room(303, "single", 40, true));
        rooms.Add(new Room(403, "double", 50, true));
        rooms.Add(new Room(501, "Suite", 60, true));
        rooms.Add(new Room(604, "double", 70.00, true));

        int choice;

        do
        {
            Console.Clear();
            Console.WriteLine("GRAND VISTA HOTEL - MANAGEMENT SYSTEM\"");
            Console.WriteLine(".............................................");
            Console.WriteLine("1. Add New Room");
            Console.WriteLine("2. Register New Guest");
            Console.WriteLine("3. Book a Room for a Guest");
            Console.WriteLine("4. View All Rooms");
            Console.WriteLine("5. View All Gusts");
            Console.WriteLine("6. Search & Filter Rooms");
            Console.WriteLine("7. Guest & Booking Statistics");
            Console.WriteLine("8. Update Room Price");
            Console.WriteLine("9. Guest Lookup by Name");
            Console.WriteLine("10. Room Type Breakdown Report");
            Console.WriteLine("11. Check Out a Guest");
            Console.WriteLine("12. Remove Unavailable Rooms");
            Console.WriteLine("13. Extend Guest Stay");
            Console.WriteLine("14. Highest Revenue Booking");
            Console.WriteLine("15. Guest Pagination Viewer");
            Console.WriteLine("0. Exit");

            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());


            switch (choice)

            {
                case 1:
                    Console.WriteLine("Add New Room");
                    break;
                case 2:
                    Console.WriteLine("Register New Guest");
                    break;


                case 3:
                    Console.WriteLine("Book Room");
                    break;


                case 4:

                    // Display all rooms
                    foreach (Room room in rooms)
                    {
                        room.DisplayRoom();
                    }

                    break;


                case 5:

                    // Display all guests
                    if (guests.Count == 0)
                    {
                        Console.WriteLine("No guests found.");
                    }
                    else
                    {
                        foreach (Guest guest in guests)
                        {
                            guest.DisplayGuest();
                        }
                    }

                    break;


                case 0:

                    Console.WriteLine("Exit program");
                    break;


                default:

                    Console.WriteLine("Invalid choice");
                    break;
            }


            if (choice != 0)
            {
                Console.WriteLine("Press any key...");
                Console.ReadKey();
            }


        } while (choice != 0);

    }

}


