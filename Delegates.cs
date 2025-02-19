using System;
using System.Collections.Generic;


namespace T4Activitats {
    public static class Delegates
    {
        // Exercici 19
        public delegate int Operacio(int x, int y);
        public static int Multiplicar(int x, int y) {
            return x * y;
        }
        public static int Dividir(int x, int y) {
            return x / y;
        }
    }
}
