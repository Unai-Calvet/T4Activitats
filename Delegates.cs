﻿using System;
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
        // Exercici 21
        public delegate void Notificacio(string message);
        public static void MostrarMissatgeConsola(string message) {
            Console.WriteLine(message);
        }
        public static void MostrarMissatgeAmbEstreles(string message) { 
            Console.WriteLine($"**********   {message}   **********");
        }
    }
}
