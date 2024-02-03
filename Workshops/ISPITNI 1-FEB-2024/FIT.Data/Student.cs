using FIT.Data.IspitIB0000000;
using System.Drawing;

namespace FIT.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string Indeks { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public byte[] Slika { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public bool Aktivan { get; set; }        
        public int SemestarId { get; set; }
        public SemestriIB000000 Semestar { get; set; }
        public int GradId { get; set; }
        public GradIB000000 Grad { get; set; }
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
