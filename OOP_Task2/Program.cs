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
                /////////////////////////////////////////////////////////////

                ///Case 04 View All Rooms
                case 4:
                    {
                        Console.WriteLine(" ALL ROOMS ");

                        // Check if list is empty
                        if (rooms.Count() == 0)
                        {
                            Console.WriteLine("No rooms have been added yet.");
                            break;
                        }

                        // Display total room count
                        Console.WriteLine($"Total Rooms: {rooms.Count()}");
                        Console.WriteLine();

                        // Sort by room number using LINQ OrderBy()
                        var sortedRooms = rooms.OrderBy(r => r.RoomNumber);

                        // Display room details
                        foreach (var room in sortedRooms)
                        {
                            Console.WriteLine($"Room Number : {room.RoomNumber}");
                            Console.WriteLine($"Room Type   : {room.RoomType}");
                            Console.WriteLine($"Price/Night : {room.PricePerNight:C}");
                            Console.WriteLine($"Status      : {(room.IsAvailable ? "Available" : "Booked")}");
                            Console.WriteLine(new string('-', 30));
                        }

                        break;
                    }
                ////////////////////////////////////////

                ///Case 05 View All Guests

                case 5:
                    {
                        Console.WriteLine("\n=== ALL GUESTS ===");

                        // Check if guest list is empty
                        if (guests.Count() == 0)
                        {
                            Console.WriteLine("No guests have been registered yet.");
                            break;
                        }

                        // Display total guest count
                        Console.WriteLine($"Total Guests: {guests.Count()}");
                        Console.WriteLine();

                        // Sort guests alphabetically by name
                        var sortedGuests = guests.OrderBy(g => g.GuestName);

                        // Display guest details
                        foreach (var guest in sortedGuests)
                        {
                            Console.WriteLine($"Guest ID      : {guest.GuestId}");
                            Console.WriteLine($"Guest Name    : {guest.GuestName}");
                            Console.WriteLine($"Room Number   : {guest.RoomNumber}");
                            Console.WriteLine($"Check-In Date : {guest.CheckInDate}");
                            Console.WriteLine($"Total Nights  : {guest.TotalNights}");
                            Console.WriteLine(new string('-', 35));
                        }

                        break;
                    }
                //////////////////////////////////////////////////

                ///Case 06 Search & Filter Rooms


                case 6:
                    {
                        int subChoice;

                        do
                        {
                            Console.WriteLine("\n=== SEARCH & FILTER ROOMS ===");
                            Console.WriteLine("1. Show All Available Rooms");
                            Console.WriteLine("2. Filter By Room Type");
                            Console.WriteLine("3. Filter By Maximum Price");
                            Console.WriteLine("4. Room Price Statistics");
                            Console.WriteLine("0. Back");
                            Console.Write("Enter Choice: ");

                            int.TryParse(Console.ReadLine(), out subChoice);

                            switch (subChoice)
                            {
                                case 1:
                                    {
                                        var availableRooms = rooms
                                            .Where(r => r.IsAvailable)
                                            .OrderBy(r => r.PricePerNight);

                                        if (!availableRooms.Any())
                                        {
                                            Console.WriteLine("No rooms found for the selected criteria.");
                                            break;
                                        }

                                        Console.WriteLine($"\nRooms Found: {availableRooms.Count()}");

                                        foreach (var room in availableRooms)
                                        {
                                            Console.WriteLine($"Room: {room.RoomNumber} | " +
                                                              $"{room.RoomType} | " +
                                                              $"{room.PricePerNight:F2} | Available");
                                        }
                                        break;
                                    }

                                case 2:
                                    {
                                        Console.Write("Enter Room Type (Single/Double/Suite): ");
                                        string roomType = Console.ReadLine();

                                        var filteredRooms = rooms
                                            .Where(r => r.RoomType.Equals(roomType,
                                                   StringComparison.OrdinalIgnoreCase))
                                            .OrderBy(r => r.RoomNumber);

                                        if (!filteredRooms.Any())
                                        {
                                            Console.WriteLine("No rooms found for the selected criteria.");
                                            break;
                                        }

                                        Console.WriteLine($"\nRooms Found: {filteredRooms.Count()}");

                                        foreach (var room in filteredRooms)
                                        {
                                            Console.WriteLine($"Room: {room.RoomNumber} | " +
                                                              $"{room.RoomType} | " +
                                                              $"{room.PricePerNight:F2} | " +
                                                              $"{(room.IsAvailable ? "Available" : "Booked")}");
                                        }
                                        break;
                                    }

                                case 3:
                                    {
                                        decimal maxPrice;

                                        Console.Write("Enter Maximum Price: ");

                                        while (!decimal.TryParse(Console.ReadLine(), out maxPrice) || maxPrice <= 0)
                                        {
                                            Console.Write("Invalid price. Enter a positive value: ");
                                        }

                                        var filteredRooms = rooms
                                            .Where(r => r.IsAvailable && r.PricePerNight <= maxPrice)
                                            .OrderBy(r => r.PricePerNight);

                                        if (!filteredRooms.Any())
                                        {
                                            Console.WriteLine("No rooms found for the selected criteria.");
                                            break;
                                        }

                                        Console.WriteLine($"\nRooms Found: {filteredRooms.Count()}");

                                        foreach (var room in filteredRooms)
                                        {
                                            Console.WriteLine($"Room: {room.RoomNumber} | " +
                                                              $"{room.RoomType} | " +
                                                              $"{room.PricePerNight:F2} | Available");
                                        }
                                        break;
                                    }

                                case 4:
                                    {
                                        if (!rooms.Any())
                                        {
                                            Console.WriteLine("No rooms found for the selected criteria.");
                                            break;
                                        }

                                        Console.WriteLine("\n=== ROOM PRICE STATISTICS ===");

                                        Console.WriteLine($"Total Rooms      : {rooms.Count()}");
                                        Console.WriteLine($"Available Rooms  : {rooms.Count(r => r.IsAvailable)}");
                                        Console.WriteLine($"Average Price    : {rooms.Average(r => r.PricePerNight):F2}");
                                        Console.WriteLine($"Cheapest Price   : {rooms.Min(r => r.PricePerNight):F2}");
                                        Console.WriteLine($"Highest Price    : {rooms.Max(r => r.PricePerNight):F2}");

                                        break;
                                    }

                                case 0:
                                    break;

                                default:
                                    Console.WriteLine("Invalid Choice.");
                                    break;
                            }

                        } while (subChoice != 0);

                        break;
                    }
                /////////////////////////////////////////////

                ///Case 07 Guest & Booking Statistics
                case 7:
                    {
                        Console.WriteLine("\n=== GUEST & BOOKING STATISTICS ===");

                        // Total Guests
                        Console.WriteLine($"Total Registered Guests : {guests.Count()}");

                        // Guests with Active Bookings
                        Console.WriteLine($"Guests With Bookings    : {guests.Count(g => g.RoomNumber != "Not Assigned")}");

                        // Room Statistics
                        Console.WriteLine($"Total Rooms             : {rooms.Count()}");
                        Console.WriteLine($"Booked Rooms            : {rooms.Count(r => !r.IsAvailable)}");

                        // Active Bookings
                        var bookedGuests = guests
                            .Where(g => g.RoomNumber != "Not Assigned");

                        if (!bookedGuests.Any())
                        {
                            Console.WriteLine("\nNo active bookings recorded.");
                            break;
                        }

                        // Average Stay Length
                        Console.WriteLine($"Average Nights Stayed   : {bookedGuests.Average(g => g.TotalNights):F2}");

                        // Top 3 Highest Spending Guests
                        Console.WriteLine("\n=== TOP 3 HIGHEST-SPENDING GUESTS ===");

                        var topGuests = bookedGuests
                            .OrderByDescending(g => g.CalculateTotalCost(rooms))
                            .Take(3);

                        foreach (var guest in topGuests)
                        {
                            Console.WriteLine(
                                $"{guest.GuestName} | Room {guest.RoomNumber} | OMR {guest.CalculateTotalCost(rooms):F2}");
                        }

                        // Guest Booking Summary
                        Console.WriteLine("\n=== BOOKING SUMMARY ===");

                        var summaries = bookedGuests.Select(g =>
                            $"{g.GuestName} — Room {g.RoomNumber} — {g.TotalNights} nights — OMR {g.CalculateTotalCost(rooms):F2}");

                        foreach (var summary in summaries)
                        {
                            Console.WriteLine(summary);
                        }

                        break;
                    }
                //////////////////////////////////////////////////////////

                ///Case 08 Update Room Price
                case 8:
                    {
                        Console.WriteLine("\n=== UPDATE ROOM PRICE ===");

                        // Get Room Number
                        Console.Write("Enter Room Number: ");
                        int roomNumber;

                        if (!int.TryParse(Console.ReadLine(), out roomNumber))
                        {
                            Console.WriteLine("Invalid room number.");
                            break;
                        }

                        // Find Room using LINQ FirstOrDefault()
                        Room room = rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);

                        if (room == null)
                        {
                            Console.WriteLine("Room not found.");
                            break;
                        }

                        // Store old price
                        decimal oldPrice = room.PricePerNight;

                        // Get new price
                        Console.Write("Enter New Price Per Night: ");
                        decimal newPrice;

                        if (!decimal.TryParse(Console.ReadLine(), out newPrice) || newPrice <= 0)
                        {
                            Console.WriteLine("Invalid price. No changes made.");
                            break;
                        }

                        // Update price
                        room.PricePerNight = newPrice;

                        // Confirmation
                        Console.WriteLine("\nRoom price updated successfully!");
                        Console.WriteLine($"Room Number : {room.RoomNumber}");
                        Console.WriteLine($"Old Price   : OMR {oldPrice:F2}");
                        Console.WriteLine($"New Price   : OMR {newPrice:F2}");

                        break;
                    }
                ///////////////////////////////////////////////

                ///Case 09 Guest Lookup by Name
                case 9:
                    {
                        Console.WriteLine("\n=== GUEST LOOKUP BY NAME ===");

                        Console.Write("Enter Name or Partial Name: ");
                        string searchText = Console.ReadLine();

                        // Search using LINQ Where() (case-insensitive)
                        var matchingGuests = guests.Where(g =>
                            g.GuestName.Contains(searchText,
                            StringComparison.OrdinalIgnoreCase));

                        // Check if any matches found
                        if (!matchingGuests.Any())
                        {
                            Console.WriteLine("No guests matched that search.");
                            break;
                        }

                        // Display count
                        Console.WriteLine($"\nMatches Found: {matchingGuests.Count()}");
                 

                        // Display guests
                        foreach (var guest in matchingGuests)
                        {
                            Console.WriteLine($"Guest ID    : {guest.GuestId}");
                            Console.WriteLine($"Guest Name  : {guest.GuestName}");
                            Console.WriteLine($"Room Number : {guest.RoomNumber}");
                           
                        }

                        break;
                    }
                //////////////////////////////////////////

                ///Case 10 Room Type Breakdown Report
                case 10:
                    {
                        Console.WriteLine("\n=== ROOM TYPE BREAKDOWN REPORT ===");

                        string[] roomTypes = { "Single", "Double", "Suite" };

                        foreach (string type in roomTypes)
                        {
                            int count = rooms.Count(r =>
                                r.RoomType.Equals(type, StringComparison.OrdinalIgnoreCase));

                            Console.WriteLine($"\nRoom Type: {type}");
                            Console.WriteLine($"Total Rooms: {count}");

                            if (count > 0)
                            {
                                double averagePrice = rooms
                                    .Where(r => r.RoomType.Equals(type, StringComparison.OrdinalIgnoreCase))
                                    .Average(r => (double)r.PricePerNight);

                                Console.WriteLine($"Average Price: OMR {averagePrice:F2}");
                            }
                            else
                            {
                                Console.WriteLine("Average Price: N/A");
                            }
                        }

                        // Overall Average Price
                        if (rooms.Any())
                        {
                            double overallAverage = rooms
                                .Average(r => (double)r.PricePerNight);

                          
                            Console.WriteLine($"Overall Average Price: OMR {overallAverage:F2}");
                        }
                        else
                        {
                            Console.WriteLine("\nOverall Average Price: N/A");
                        }

                        break;
                    }
                /////////////////////////////////////

                //Case 11 Check Out a Guest
                case 11:
                    {
                        Console.WriteLine("\n=== CHECK OUT A GUEST ===");

                        // Step 1: Get Guest ID
                        Console.Write("Enter Guest ID: ");
                        string guestId = Console.ReadLine();

                        // Step 2: Find Guest
                        Guest guest = guests.FirstOrDefault(g => g.GuestId == guestId);

                        if (guest == null)
                        {
                            Console.WriteLine("Guest not found.");
                            break;
                        }

                        // Step 3: Ensure Guest Has a Booking
                        if (guest.RoomNumber == "Not Assigned")
                        {
                            Console.WriteLine("This guest has no active booking.");
                            break;
                        }

                        // Step 4: Find Linked Room
                        int roomNo = int.Parse(guest.RoomNumber);

                        Room room = rooms.FirstOrDefault(r => r.RoomNumber == roomNo);

                        if (room == null)
                        {
                            Console.WriteLine("Linked room record not found.");
                            break;
                        }

                        // Step 5: Display Final Bill
                        double totalCost = guest.CalculateTotalCost(rooms);

                        Console.WriteLine("\n===== FINAL BILL =====");
                        Console.WriteLine($"Guest Name      : {guest.GuestName}");
                        Console.WriteLine($"Room Number     : {room.RoomNumber}");
                        Console.WriteLine($"Room Type       : {room.RoomType}");
                        Console.WriteLine($"Check-In Date   : {guest.CheckInDate}");
                        Console.WriteLine($"Total Nights    : {guest.TotalNights}");
                        Console.WriteLine($"Price Per Night : OMR {room.PricePerNight:F2}");
                        Console.WriteLine($"Total Cost      : OMR {totalCost:F2}");

                        // Step 6: Confirm Checkout
                        Console.Write("\nConfirm Checkout (Y/N): ");
                        string confirm = Console.ReadLine().ToUpper();

                        if (confirm == "Y")
                        {
                            // Free Room First
                            room.IsAvailable = true;

                            // Remove Guest
                            guests.Remove(guest);

                            // Step 7: Summary
                            Console.WriteLine("\nCheckout Successful!");
                            Console.WriteLine($"Guest {guest.GuestName} has been checked out.");

                            Console.WriteLine($"\nTotal Guests: {guests.Count}");
                            Console.WriteLine($"Total Rooms : {rooms.Count}");

                            bool roomAvailable =
                                rooms.Any(r => r.RoomNumber == roomNo && r.IsAvailable);

                            Console.WriteLine($"Room Available: {roomAvailable}");
                        }
                        else
                        {
                            Console.WriteLine("Checkout cancelled. No changes were made.");
                        }

                        break;
                    }
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


