using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IspitIB0000000
{
    public class GradIB000000
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public bool Aktivan { get; set; }
        public int DrzavaID { get; set; }
        public DrzavaIB000000 Drzava {  get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
