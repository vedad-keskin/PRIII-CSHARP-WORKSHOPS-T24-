using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IspitIB180079
{
    public class NastavaIB180079
    {
        public int Id { get; set; }
        public int ProstorijaId { get; set; }
        public ProstorijeIB180079 Prostorija { get; set; }
        public int PredmetId { get; set; }
        public PredmetiIB180079 Predmet { get; set; }
        public string Vrijeme { get; set; }
        public string Dan { get; set; }
        public string Oznaka { get; set; }


        public override string ToString()
        {
            return $"{Predmet} :: {Dan} :: {Vrijeme}";
        }
    }
}
