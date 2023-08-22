using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_V3
{
     class Time
     {
        internal static bool IsTimeValid(string timeString)
        {
            // Задайте ожидаемый формат времени (ЧЧ мм)
            string format = "HH mm";

            // Попробуйте преобразовать введенную строку времени в объект DateTime
            if (DateTime.TryParseExact(timeString, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                // Если преобразование прошло успешно, время введено правильно
                return true;
            }

            return false;
        }
    }
}
