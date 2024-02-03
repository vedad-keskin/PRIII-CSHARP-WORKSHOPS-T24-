using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IspitIB0000000
{
    public class DrzavaIB000000
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public byte[] Zastava { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
