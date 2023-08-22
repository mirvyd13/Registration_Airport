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
    public partial class MainWindow : Window
    {
        private ObservableCollection<Passenger> passengers; // Коллекция пассажиров

        public MainWindow()
        {
            InitializeComponent();
            passengers = new ObservableCollection<Passenger>();
            dataGridPassengers.ItemsSource = passengers;
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)//Сохранение Файла
        {
            buttonSave_Click_Class.Save_Class(sender, e, passengers);
        }

        private void LoadPassengersFromFile(string filePath)//Считывание  Файла
        {
            Load_Class.Load(filePath, passengers, dataGridPassengers);
        }

        private void addPassengerOpen_Click(object sender, RoutedEventArgs e)//Открытие окна добавление пассажира
        {
            Add_Pas_Class.Add_Open_Pas(passengers);
        }

        private void buttonClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void buttonOpen_Click(object sender, RoutedEventArgs e)//Открытие считанного Файла
        {
            OpenFileDialog ofd = new OpenFileDialog();
            bool? res = ofd.ShowDialog();

            if (res != false)
            {
                if (ofd.FileName != null)
                {
                    string file_name = ofd.FileName;
                    LoadPassengersFromFile(file_name);
                }
            }
        }

        private void buttonDel_Click(object sender, RoutedEventArgs e)//Удаление пассажира
        {
            Delete_Pas.Del(passengers, dataGridPassengers);
        }
    }
}