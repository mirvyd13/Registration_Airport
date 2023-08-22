using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Zadanie_V3
{
    class Delete_Pas
    {
        internal static void Del(ObservableCollection<Passenger> passengers, DataGrid dataGridPassengers)
        {
            if (dataGridPassengers.SelectedItems.Count > 0)
            {
                // Получаем выбранный элемент (пассажира)
                Passenger selectedPassenger = dataGridPassengers.SelectedItem as Passenger;

                // Удаляем выбранный элемент из коллекции
                if (selectedPassenger != null)
                {
                    passengers.Remove(selectedPassenger);
                }
            }
        }
    }
}
