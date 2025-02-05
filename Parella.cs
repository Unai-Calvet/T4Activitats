using System;
using System.Collections.Generic;

namespace T4Activitats {
    public class Parella<T1, T2> {
        public T1 PrimerValor { get; set; }
        public T2 SegonValor { get; set; }
        public Parella (T1 primerValor, T2 segonValor) {
            PrimerValor = primerValor;
            SegonValor = segonValor;
        }
        public void MostrarValors() {
        Console.WriteLine("Primer Valor valor {0}, Segon Valor {1}", PrimerValor, SegonValor);
        }
    }
}
