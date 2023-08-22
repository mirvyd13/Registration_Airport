using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Collections.ObjectModel;
using Microsoft.Win32;
using System.IO.Ports;


namespace Zadanie_V3
{
     class Load_Class
     {
        internal static void Load(string filePath, ObservableCollection<Passenger> passengers, DataGrid dataGridPassengers)
        {

            if (File.Exists(filePath))
            {
                passengers.Clear();
                string[] lines = File.ReadAllLines(filePath);
                foreach (string parts in lines)
                {
                    string[] values = parts.Split(',');
                    if (values.Length == 5)
                    {
                        string flightDate = values[0].ToString();
                        string flightTime = values[1].ToString();
                        string flightNumber = values[2].ToString();
                        string passengerName = values[3].ToString();
                        string phone = values[4].ToString();

                        Passenger passenger = new Passenger(flightDate, flightTime, flightNumber, passengerName, phone);
                        passengers.Add(passenger);
                    }
                    dataGridPassengers.Items.Refresh();

                }
                MessageBox.Show("Данные загружены.");
            }
            else
            {
                MessageBox.Show("Файл не найден.");
            }
        }
    }
}
