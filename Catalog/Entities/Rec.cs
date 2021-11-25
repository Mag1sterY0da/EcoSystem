using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Rec
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public Boolean Pollution { get; set; }
        public string Pollution_type { get; set; }
        public int Pollution_metrics { get; set; }

    }
}
