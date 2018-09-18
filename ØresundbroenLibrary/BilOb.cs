using System;
using BilletLibrary;

namespace ØresundbroenLibrary
{
    public class BilOb : Vehicle
    {
        private string _nummerPlade;

        public string NummerPlade
        {
            get => _nummerPlade;
            set => _nummerPlade = value.Length <= 7 ? value
                : throw new ArgumentException("Nummerpladen må ikke være længere end 7 tegn!");
        }
        public DateTime Dato { get; set; }
        public bool Brobizz { get; set; }

        public override string Køretøj() => "Øresund Bil";
        public override decimal Pris() => !Brobizz ? 410 : 161;
    }
}
