using System;
using System.Collections;
using System.Collections.Generic;

namespace T4Activitats {
    public static class Utils {
        public static int AskIntValue() {
            const string Message = "Introdueix un valor enter: ";
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
        public static string AskStringValue(string message) {
            Console.WriteLine(message);
            return Console.ReadLine() ?? "Nom desconegut";
        }
        public static string AskStringValue() {
            const string Message = "Introdueix un valor de text";
            Console.WriteLine(Message);
            return Console.ReadLine() ?? "Nom desconegut";
        }
        public static int AskNaturalValue(string message) {
            int num;
            num = AskIntValue(message);
            return num >= 0 ? num : AskNaturalValue(message);
        }

        public static void WriteArrayList(ArrayList arrayList)
        {
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
