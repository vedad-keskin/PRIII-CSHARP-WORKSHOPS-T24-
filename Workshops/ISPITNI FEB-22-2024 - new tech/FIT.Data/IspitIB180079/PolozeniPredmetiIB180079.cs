using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IspitIB180079
{
    public class PolozeniPredmetiIB180079
    {

        public int Id { get; set; }

        public int StudentId { get; set; } // 1 
        public Student Student { get; set; } // Jasmin Azemovic IB123 3

        public int PredmetId { get; set; }
        public PredmetiIB180079 Predmet { get; set; }

        public int Ocjena { get; set; }

        public DateTime DatumPolaganja { get; set; }
        public string Napomena { get; set; }


    }
}
