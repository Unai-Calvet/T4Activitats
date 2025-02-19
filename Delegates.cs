using System;
using System.Collections.Generic;


namespace T4Activitats {
    public static class Delegates
    {
        // Exercici 19
        public delegate int Operacio(int x, int y);
        // Exercici 20
        public static int ExecutarOperacio(int x, int y, Operacio ops) {
            return ops(x, y);
        } 
    }
}
