using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_V3
{
    internal class Add_Pas_Class
    {
        internal static void Add_Open_Pas(ObservableCollection<Passenger> passengers)
        {
            ADD_Pas open = new ADD_Pas();
            open.ShowDialog();
            if (open.DialogResult == true)
            {
                Passenger passenger = new Passenger(open.FlightDate, open.FlightTime, open.FlightNumber, open.PassengerName, open.Phone);
                passengers.Add(passenger);
            }
        }
    }
}
