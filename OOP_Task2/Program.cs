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
        public string GuestId { get; set; }
        public string GuestName { get; set; }
        public int RoomNumber { get; set; }
        public string CheckInDate { get; set; }
        public int TotalNights { get; set; }

        public Guest(string guestId,
             string guestName,
             int roomNumber,
             string checkInDate,
             int totalNights)
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
            Console.WriteLine("Check In Date" + CheckInDate);
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

        //Main Menu Blueprint
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
                //////////Case 01 Add New Room
                case 1:
                    Console.WriteLine("Enter Room Number:");
                    int roomNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Room Type (double , single , suite)");
                    string roomType = Console.ReadLine();
                    Console.WriteLine("Enter Price per Night:");
                    double price = Convert.ToDouble(Console.ReadLine());
                    if (roomNumber <= 0 || price <= 0)
                    {
                        Console.WriteLine("Room number and price must be positive numbers.");
                        break;
                    }
                    // Check if room number already exists using LINQ Any()
                    bool roomExists = rooms.Any(r => r.RoomNumber == roomNumber);
                    if (roomExists)
                    {
                        Console.WriteLine("Error: Room number already exists.");
                        break;
                    }
                    // Create new Room object and add it to the list
                    Room room = new Room(roomNumber, roomType, price, true);
                    rooms.Add(room);
                    // Display success message
                    Console.WriteLine("Room added successfully!");
                    Console.WriteLine("Room Number: " + roomNumber);
                    Console.WriteLine("Room Type: " + roomType);
                    Console.WriteLine("Price Per Night: " + price);
                    Console.WriteLine("Total Rooms: " + rooms.Count);
                    break;
                ////////////////////////////////////////////////////
                ///Case 02 Register New Guest
                case 2:
                
                    {
                        Console.WriteLine(" === REGISTER NEW GUEST ===");
                        // Guest Name
                        Console.Write("Enter Guest Name: ");
                        string guestName = Console.ReadLine();

                        // Check-In Date
                        Console.Write("Enter Check-In Date: ");
                        string checkInDate = Console.ReadLine();

                        // Number of Nights Validation
                        int totalNights;
                        Console.Write("Enter Number of Nights: ");

                        while (!int.TryParse(Console.ReadLine(), out totalNights) ||
                               totalNights <= 0)
                        {
                            Console.Write("Invalid input. Enter a positive number of nights: ");
                        }
                        // Auto-Generate Guest ID
                        string guestId = $"G{(guests.Count + 1):D3}";
                        // Create Guest Object
                        Guest newGuest = new Guest(
                            guestId,
                            guestName,
                            "Not Assigned",
                            checkInDate,
                            totalNights
                        );
                        // Add to List
                        guests.Add(newGuest);
                        // Confirmation Message
                        Console.WriteLine(" Guest Registered Successfully!");
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine($"Guest ID      : {newGuest.GuestId}");
                        Console.WriteLine($"Guest Name    : {newGuest.GuestName}");
                        Console.WriteLine($"Room Number   : {newGuest.RoomNumber}");
                        Console.WriteLine($"Check-In Date : {newGuest.CheckInDate}");
                        Console.WriteLine($"Total Nights  : {newGuest.TotalNights}");
                        Console.WriteLine($"Total Guests Registered: {guests.Count}");
                        break;
                    }
                ////////////////////////////////////////////////////////////////

                ///Case 03 Book a Room for a Guest
                case 3:
                    {
                        Console.WriteLine(" === BOOK A ROOM FOR A GUEST ===");
                        // Get Guest ID
                        Console.Write("Enter Guest ID: ");
                        string guestId = Console.ReadLine();

                        // Get Room Number
                        Console.Write("Enter Room Number: ");
                        int roomNumber;

                        while (!int.TryParse(Console.ReadLine(), out roomNumber))
                        {
                            Console.Write("Invalid room number. Try again: ");
                        }

                        // Find Guest using LINQ FirstOrDefault()
                        Guest guest = guests.FirstOrDefault(g => g.GuestId == guestId);

                        if (guest == null)
                        {
                            Console.WriteLine("Guest not found.");
                            break;
                        }

                        // Find Room using LINQ FirstOrDefault()
                        Room room = rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);

                        if (room == null)
                        {
                            Console.WriteLine("Room not found.");
                            break;
                        }

                        // Check Availability
                        if (!room.IsAvailable)
                        {
                            Console.WriteLine("Room is already booked.");
                            break;
                        }

                        // Assign Room to Guest
                        guest.RoomNumber = room.RoomNumber;

                        // Mark Room as Booked
                        room.IsAvailable = false;

                        // Calculate Cost
                        double totalCost = guest.CalculateTotalCost(rooms);

                        // Confirmation
                        Console.WriteLine("\n=== BOOKING CONFIRMATION ===");
                        Console.WriteLine($"Guest Name      : {guest.GuestName}");
                        Console.WriteLine($"Room Number     : {room.RoomNumber}");
                        Console.WriteLine($"Room Type       : {room.RoomType}");
                        Console.WriteLine($"Price Per Night : {room.PricePerNight:C}");
                        Console.WriteLine($"Total Nights    : {guest.TotalNights}");
                        Console.WriteLine($"Total Cost      : {totalCost:C}");

                        break;
                    }


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


