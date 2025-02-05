using System;
using System.Collections.Generic;

namespace T4Activitats {
    public static class Utils {
        public static int AskIntValue() {
            const string Message = "Introdueix un valor enter"
            int intNum;

            Console.WriteLine(Message);
            if (Int32.TryParse(Console.ReadLine(), out intNum)) { 
                return intNum;
            }
            return AskIntValue();
        }
        public static int AskIntValue(string message) {
            int intNum;

            Console.WriteLine(message);
            if (Int32.TryParse(Console.ReadLine(), out intNum)) {
                return intNum;
            }
            return AskIntValue();
        }
    }
}
