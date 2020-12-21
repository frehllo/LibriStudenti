using System;

namespace ClassiAcquistiStudentiLibri
{
    public class Studente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int nMatricola { get; set; } = 0;


        public Studente(string n, string c, int m)
        {
            Nome = n;
            Cognome = c;
            nMatricola = m;
        }

        public string GetProprieta()
        {
            return $"MATR : {nMatricola} {Nome} {Cognome}";
        }
    }
}
