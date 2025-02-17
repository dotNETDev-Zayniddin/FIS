/*1. Create a class Flight with the following properties:

• FlightNumber (string)

• Origin (string)

• Destination (string)

• DepartureTime (DateTime)

• ArrivalTime (DateTime)

• Status (string: "On Time", "Delayed", or "Cancelled")*/
using System;
namespace fisLinQ
{
    class Flight
    {
        public string FlightNumber { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string Status { get; set; } 
       
    }
}