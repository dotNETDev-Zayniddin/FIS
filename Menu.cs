/*3. Use LINQ to:

• Display all flights originating from a specific city (filter by Origin).

• Display flights sorted by DepartureTime.

• Display flights with the status "Delayed" or "Cancelled".

• Display the earliest departing flight.

4. Provide a menu-driven interface to allow the user to select and perform any of the above queries.
*/

using System;
using System.Net;
using System.Reflection;
using System.Xml.Linq;
namespace fisLinQ
{
    static class Menu
    {
        public static void Run(List<Flight> flights)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Flight Information system");
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine("1. Display by Origin");
            System.Console.WriteLine("2. Display by Departure time");
            System.Console.WriteLine("3. Display by Status");
            System.Console.WriteLine("4. Display the earliest departing flight");
            System.Console.WriteLine("5. Exit");
            System.Console.Write("Enter your choice: ");
            
            string choice = Console.ReadLine();
            switch(choice)
            {
                case "1": 
                {
                    DisplayByOrigin(flights);
                    break;
                }
                    case "2": 
                {
                    DisplayByDepartureTime(flights);
                    break;
                }
                    case "3": 
                {
                    DisplayByStatus(flights);
                    break;
                }
                    case "4": 
                {
                    DisplayEarliestOne(flights);
                    break;
                }
                    case "5": 
                {
                    System.Console.WriteLine("Program finished...");
                    Environment.Exit(0);
                    break;
                }
                default:
                {
                    break;
                }
            }  
        }
        //MENU 1
        static private void DisplayByOrigin(List<Flight> flights)
       {
            var filtered = flights.Select(n => n.Origin).Distinct().OrderBy(origin => origin);
            int i = 0;
            List<string> list = new List<string>();
            
            foreach (var temp in filtered)
            {
                i++;
                System.Console.WriteLine($"{i}) {temp}");
                list.Add(temp);
            }
            bool working = true;
            while(working)
            {
            System.Console.Write("Enter flight you want to know:(q to exit) ");
            string input = Console.ReadLine();
            if(input == "q")
            {
              working = false;
            }
            else if(!int.TryParse(input, out int choice) || choice > list.Count || choice < 1)
            {
                System.Console.WriteLine("Error input. Try again.");
            }
            else
            {
                   var DisplayInner = flights.Where(n => n.Origin == list[choice-1]);
                   foreach(var x in DisplayInner)
                   {
                        Display(x);
                        working = false;
                   }
            }       
            }
       }
        //MENU 2
        static private void DisplayByDepartureTime(List<Flight> flights)
        {
            List<DateTime> toDisplay = new List<DateTime>();
            int i = 0;
            var filtered = flights.Select(n => n.DepartureTime).Distinct().OrderBy(x => x);
            foreach(var temp in filtered)
            {
                i++;
                System.Console.WriteLine($"{i}) {temp}");
                toDisplay.Add(temp);
            }
            System.Console.WriteLine("Enter a time you want to know:");

            if(!int.TryParse(Console.ReadLine(), out int choice))
            {
                System.Console.WriteLine("Error input");
            }
            else
            {
              
                    var DisplayInner = flights.Where(n => toDisplay.Contains(n.DepartureTime));
                    int j = 0;
                    foreach(var x in DisplayInner)
                    {
                        if(x.DepartureTime == toDisplay[choice-1])
                        {
                            Display(x);
                        }
                    }
                }
         
            }
        //MENU 3
        static private void DisplayByStatus(List<Flight> flights)
        {
            var filtered = flights.GroupBy(n => n.Status);
            int i = 1;
            List<string> groupList = new List<string>();
            foreach(var group in filtered)
            {
                System.Console.WriteLine($"{i}) {group.Key}");
                groupList.Add(group.Key.ToString());
                i++; 
            }
            System.Console.WriteLine("Enter a number you want to know about flights by status:(enter q to quit) ");
            string input = Console.ReadLine();
                if(input.Equals("q"))
                {
                        Menu.Run(flights);
                }
                if(!int.TryParse(input, out int choice) || choice  > groupList.Count || choice < 1)
                {
                    System.Console.WriteLine("Error input!");
                    DisplayByStatus(flights);
                }
            else
            {
                 string selectedStatus = groupList[choice - 1];
                 var selectedFlights = filtered.First(g => g.Key.ToString() == selectedStatus);

                System.Console.WriteLine($"Flights with status '{selectedStatus}':");
                foreach (var flight in selectedFlights)
                {
                    Display(flight);
                    System.Console.WriteLine("_________________________________________");
                }
            }
            }
        //MENU 4
        static private void DisplayEarliestOne(List<Flight> flights)
        {
            System.Console.WriteLine("The earliest arrival time is: ");
            var filtered = flights.OrderBy(n => n.ArrivalTime).First();
            var last = flights.OrderBy(n => n.ArrivalTime).Last();
            Display(filtered);
        }
        static private void Display(Flight obj)
        {
            Console.WriteLine($"{obj.FlightNumber} to {obj.Destination} departs at {obj.DepartureTime}");
        }
    }
}
