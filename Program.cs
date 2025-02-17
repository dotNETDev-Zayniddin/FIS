using System;
using System.Xml.Linq;
using System.Xml.Serialization;
namespace fisLinQ
    {
    public class Program
    {
        public static void Main()
        {
            List<Flight> flights = new List<Flight>
            {
                new Flight
                {
                    FlightNumber = "AA101",
                    Origin = "New York",
                    Destination = "Los Angeles",
                    DepartureTime = new DateTime(2025, 2, 16, 8, 0, 0),
                    ArrivalTime = new DateTime(2025, 2, 16, 11, 0, 0),
                    Status = "On Time"
                },
                new Flight
                {
                    FlightNumber = "BA202",
                    Origin = "London",
                    Destination = "New York",
                    DepartureTime = new DateTime(2025, 2, 16, 10, 0, 0),
                    ArrivalTime = new DateTime(2025, 2, 16, 14, 0, 0),
                    Status = "Delayed"
                },
                new Flight
                {
                    FlightNumber = "CA303",
                    Origin = "Tokyo",
                    Destination = "San Francisco",
                    DepartureTime = new DateTime(2025, 2, 16, 9, 0, 0),
                    ArrivalTime = new DateTime(2025, 2, 16, 17, 0, 0),
                    Status = "Cancelled"
                },
                new Flight
                {
                    FlightNumber = "DA404",
                    Origin = "Paris",
                    Destination = "Berlin",
                    DepartureTime = new DateTime(2025, 2, 16, 7, 30, 0),
                    ArrivalTime = new DateTime(2025, 2, 16, 9, 0, 0),
                    Status = "On Time"
                },
                new Flight
                {
                    FlightNumber = "EA505",
                    Origin = "Sydney",
                    Destination = "Melbourne",
                    DepartureTime = new DateTime(2025, 2, 16, 12, 0, 0),
                    ArrivalTime = new DateTime(2025, 2, 16, 13, 30, 0),
                    Status = "Delayed"
                },
                new Flight
                {
                    FlightNumber = "FA606",
                    Origin = "Dubai",
                    Destination = "Doha",
                    DepartureTime = new DateTime(2025, 2, 16, 15, 0, 0),
                    ArrivalTime = new DateTime(2025, 2, 16, 16, 30, 0),
                    Status = "On Time"
                },
                new Flight
                {
                    FlightNumber = "GA707",
                    Origin = "Moscow",
                    Destination = "Istanbul",
                    DepartureTime = new DateTime(2025, 2, 16, 6, 0, 0),
                    ArrivalTime = new DateTime(2025, 2, 16, 9, 30, 0),
                    Status = "Cancelled"
                },
                new Flight
                {
                    FlightNumber = "HA808",
                    Origin = "Toronto",
                    Destination = "Chicago",
                    DepartureTime = new DateTime(2025, 2, 16, 11, 0, 0),
                    ArrivalTime = new DateTime(2025, 2, 16, 12, 30, 0),
                    Status = "On Time"
                },
                new Flight
                {
                    FlightNumber = "IA909",
                    Origin = "Singapore",
                    Destination = "Bangkok",
                    DepartureTime = new DateTime(2025, 2, 16, 13, 0, 0),
                    ArrivalTime = new DateTime(2025, 2, 16, 15, 0, 0),
                    Status = "Delayed"
                },
                new Flight
                {
                    FlightNumber = "JA010",
                    Origin = "Rome",
                    Destination = "Athens",
                    DepartureTime = new DateTime(2025, 2, 16, 14, 0, 0),
                    ArrivalTime = new DateTime(2025, 2, 16, 16, 30, 0),
                    Status = "On Time"
                },
                 new Flight
                {
                    FlightNumber = "JA011",
                    Origin = "Rome",
                    Destination = "Athens",
                    DepartureTime = new DateTime(2025, 2, 16, 14, 0, 0),
                    ArrivalTime = new DateTime(2025, 2, 16, 16, 30, 0),
                    Status = "On Time"
                }
            };  
            Menu.Run(flights);
       }
    }
}