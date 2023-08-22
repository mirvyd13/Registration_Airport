using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Zadanie_V3;

namespace Zadanie_V3
{
    public partial class ADD_Pas : Window
    {
        public string FlightDate { get; set; }
        public string FlightTime { get; set; }
        public string FlightNumber { get; set; }
        public string PassengerName { get; set; }
        public string Phone { get; set; }

        public ADD_Pas()
        {
            InitializeComponent();
        }

        private void exit_folder_Click(object sender, RoutedEventArgs e)//выход
        {
            Visibility = Visibility.Hidden;
        }

        private void addPassenger_Click(object sender, RoutedEventArgs e)//добавление пассажира
        {
            FlightDate = textBoxFlightDate.Text.ToString();
            FlightTime = textBoxFlightTime.Text.ToString();
            FlightNumber = textBoxFlightNumber.Text.ToString();
            PassengerName = textBoxPassengerName.Text.ToString().ToUpper();
            Phone = textBoxPhone.Text.ToString();

            
            if (IsValidData())
            {
                DialogResult = true;
            }
            else
            {
                Name_Error();              
            }
        }

        private bool IsValidData()
        {
            //  проверка на пустые поля:
            if (string.IsNullOrWhiteSpace(FlightTime) ||
                string.IsNullOrWhiteSpace(FlightNumber) ||
                string.IsNullOrWhiteSpace(PassengerName) ||
                string.IsNullOrWhiteSpace(Phone))
            {
                MessageBox.Show("Все поля должны быть заполнены.");
                return false;
            }                     
            // Если все проверки прошли успешно, вернуть true        
            if (Name_Error()&& Time_Error()&&Phone_Error(Phone))
                return true;
            return false;
        }

        private bool Time_Error()// проверка времени
        {
            if (!Time.IsTimeValid(FlightTime))
            {
                MessageBox.Show("Неверный формат времени. Введите время в формате \"ЧЧ мм\".");
                return false;
            }
            return true;
        }

        private bool Name_Error()//Проверка имени
        {
            foreach (char c in PassengerName)
            {
                if (!char.IsLetter(c))
                {
                    MessageBox.Show("Неверное имя. Имя должно содержать только буквы.");
                    return false;
                }             
            }
            return true;
        }

        private void datePickerFlightDate_SelectedDateChanged_1(object sender, SelectionChangedEventArgs e)//подстановка даты
        {
            DateTime? selectedDate = datePickerFlightDate.SelectedDate;
            if (selectedDate.HasValue)
            {
                textBoxFlightTime.Text = ""; // Очищаем поле времени, чтобы убрать предыдущее значение времени
                textBoxFlightDate.Text = selectedDate.Value.ToString("dd/MM/yyyy");
            }
        }  

        private bool Phone_Error(string Phone)
        {
            if (Phone.All(char.IsDigit))
            {
                return true;
            }
            MessageBox.Show("Телефон введен не коректно");
            return false; 
        }
    }
}