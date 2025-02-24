using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

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
        /// <summary>
        /// Multiplies the two integer numbers
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int Multiplicar(int x, int y) {
            return x * y;
        }
        /// <summary>
        /// Divides the two integer numbers
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int Dividir(int x, int y) {
            return x / y;
        }
        /// <summary>
        /// Validates an email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool IsValidEmail(string email) {
            string pattern = @"^([\w\.\-]+)@gmail.com$";
            return Regex.IsMatch(email, pattern);
        }
        /// <summary>
        /// Validates a spanish phone number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsValidPhoneNumber(string number) {
            string pattern = @"^(\+34)? ?[6-7][0-9]{2} ?[0-9]{3} ?[0-9]{3}$";
            return Regex.IsMatch(number, pattern);
        }
        /// <summary>
        /// Extracts the numbers from a string
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string ExtractNumbers(string text) { 
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++) {
                if (Regex.IsMatch(text[i].ToString(), @"[0-9]")) {
                    
                    while (i < text.Length && Regex.IsMatch(text[i].ToString(), @"[0-9]")) {
                        sb.Append(text[i]);
                        i++;
                    }
                    sb.Append(", ");
                }
            }
            Console.WriteLine(sb.Length);
            sb.Remove(sb.Length - 2, 2);
            return sb.ToString();
        }
        /// <summary>
        /// Validates a password
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool IsValidPassword(string password) { 
            if (!(password.Length >= 8)) { 
                return false; 
            }
            if (!Regex.IsMatch(password, @"[A-Z]")) { 
                return false;
            }
            if (!Regex.IsMatch(password, @"[a-z]")) {
                return false;
            }
            if (!Regex.IsMatch(password, @"[0-9]")) {
                return false;
            }
            if (!Regex.IsMatch(password, @"[\W]")) {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Validates spanish postal code
        /// </summary>
        /// <param name="postalCode"></param>
        /// <returns></returns>
        public static bool IsValidPostalCode(string postalCode) {
            return (postalCode.Length == 5 && Regex.IsMatch(postalCode, @"^[01-52]"));
        }
    }
}
