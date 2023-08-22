using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_V3
{
    public class Passenger
    {
        public string FlightDate { get; set; }
        public string FlightTime { get; set; }
        public string FlightNumber { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Passenger(string _FlightDate, string _FlightTime, string _FlightNumber, string _Name, string _Phone)
        {
            FlightDate = _FlightDate;
            FlightTime = _FlightTime;
            FlightNumber = _FlightNumber;
            Name = _Name;
            Phone = _Phone;
        }
    }
}
