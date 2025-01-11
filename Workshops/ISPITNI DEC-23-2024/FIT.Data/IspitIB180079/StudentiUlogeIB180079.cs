using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IspitIB180079
{
    public class StudentiUlogeIB180079
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int UlogaId { get; set; }
        public UlogeIB180079 Uloga { get; set; }

        public string Indeks => Student.Indeks ?? "N/A";

        public string StudentInfo => $"{Student.Ime} {Student.Prezime} ({DateTime.Now.Year - Student.DatumRodjenja.Year})" ?? "N/A";

        public string DatumRodjenja => Student.DatumRodjenja.ToString() ?? "N/A";

        public bool Aktivan => Student.Aktivan;

        [NotMapped]
        public double Prosjek { get; set; }


    }
}
