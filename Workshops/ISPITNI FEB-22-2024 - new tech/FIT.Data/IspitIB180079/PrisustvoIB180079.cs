using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IspitIB180079
{
    public class PrisustvoIB180079
    {
        public int Id { get; set; }
        public int NastavaId { get; set; }
        public NastavaIB180079 Nastava { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
