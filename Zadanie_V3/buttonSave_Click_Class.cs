using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Zadanie_V3
{
    class buttonSave_Click_Class
    {
        internal static void Save_Class(object sender, RoutedEventArgs e, ObservableCollection <Passenger> passengers)//Сохранение Файла
        {
            SaveFileDialog sfd = new SaveFileDialog();
            bool? res = sfd.ShowDialog();

            if (res != false)
            {

                using (Stream s = File.Open(sfd.FileName, FileMode.OpenOrCreate))
                {
                    using (StreamWriter sw = new StreamWriter(s))
                    {
                        foreach (Passenger passenger in passengers)
                        {
                            sw.WriteLine($"{passenger.FlightDate},{passenger.FlightTime},{passenger.FlightNumber},{passenger.Name},{passenger.Phone}");
                        }
                    }
                    MessageBox.Show("Данные сохранены.");
                }
            }
        }
    }
}
