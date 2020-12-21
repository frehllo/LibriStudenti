using System;
using System.Collections.Generic;
using System.Text;

namespace ClassiAcquistiStudentiLibri
{
    public class Libro
    {
        public string Materia { get; private set; }
        public double Prezzo { get; private set; }
        public string ISBN { get; set; }

        public Libro(string materia, double prezzo, string isbn)
        {
            Materia = materia;
            Prezzo = prezzo;
            ISBN = isbn;
        }

        public string GetProprieta()
        {
            return ($"ISBN:{ISBN} {Materia} {Prezzo}");
        }
    }
}
