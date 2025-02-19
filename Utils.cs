using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace T4Activitats {
    public static class Utils {

        /// <summary>
        /// Asks an int value to the user using the message passed as an argument and returns its value
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static int AskIntValue(string message)
        {
            int intNum;

            Console.WriteLine(message);
            if (Int32.TryParse(Console.ReadLine(), out intNum))
            {
                return intNum;
            }
            return AskIntValue();
        }

        /// <summary>
        /// Asks an int value written to the user and returns it
        /// </summary>
        /// <returns></returns>
        public static int AskIntValue() {
            const string Message = "Introdueix un valor enter: ";
            int intNum;

            Console.WriteLine(Message);
            if (Int32.TryParse(Console.ReadLine(), out intNum)) { 
                return intNum;
            }
            return AskIntValue();
        }

        /// <summary>
        /// Asks a string value to the user using the message passed as an argument and returns its value
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static string AskStringValue(string message) {
            Console.WriteLine(message);
            return Console.ReadLine() ?? "Nom desconegut";
        }

        /// <summary>
        /// Asks a string value to the user and returns its value
        /// </summary>
        /// <returns></returns>
        public static string AskStringValue() {
            const string Message = "Introdueix un valor de text";
            Console.WriteLine(Message);
            return Console.ReadLine() ?? "Nom desconegut";
        }

        /// <summary>
        /// Asks a date value to the user and returns its value
        /// </summary>
        /// <returns></returns>
        public static DateTime AskDateTime() {
            const string Message = "Introdueix una data (dd/mm/aaaa)";
            const string ErrorMessage = "Error: Valor introduit invàlid. ";
            DateTime data;
            try {
                Console.WriteLine(Message);
                data = DateTime.ParseExact(Console.ReadLine(), "d", new CultureInfo("es-ES"));
                return data;
            } catch (FormatException) {
                Console.WriteLine(ErrorMessage);
                return AskDateTime();
            }
        }

        /// <summary>
        /// Asks a future date value to the user and returns its value
        /// </summary>
        /// <returns></returns>
        public static DateTime AskFutureDateTime() {
            const string NotFutureDateMessage = "Data introduida no futura";
            DateTime data;
            data = AskDateTime();
            if (data > DateTime.Today) {
                Console.WriteLine(NotFutureDateMessage);
                return data;
            }

            return AskFutureDateTime();
        }

        /// <summary>
        /// Asks a natural value to the user using the message passed as an argument and returns its value
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static int AskNaturalValue(string message) {
            int num;
            num = AskIntValue(message);
            return num >= 0 ? num : AskNaturalValue(message);
        }
        /// <summary>
        /// Asks and compares two dates
        /// </summary>
        public static void AskTwoDatesAndCompare() {
            DateTime firstDate;
            DateTime secondDate;
            firstDate = AskDateTime();
            secondDate = AskDateTime();
            Console.WriteLine(secondDate.CompareTo(firstDate) > 0? "La segona data es posterior a la primera" : "La segona data NO es posterior a la primera");
        }
        /// <summary>
        /// Gets today's day of the week
        /// </summary>
        /// <returns></returns>
        public static string GetNowWeekDay() { 
            return DateTime.Now.DayOfWeek.ToString();
        }
        /// <summary>
        /// Returns the years of a timeSpan value
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static int TotalYears(TimeSpan time) {
            return (int) time.TotalDays / 365;
        }
    }
}
