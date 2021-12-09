using Prototype.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.ConcretePrototypes
{
    public class RecNoPul : IRec
    {
        public int Id { get; private set; }
        public string Date { get; set; }
        public Boolean Pollution { get; set; }
        public string Pollution_type { get; set; }

        public RecNoPul(int id, string date, Boolean pollution, string pollution_type)
        {
            Id = id;
            Date = date;
            Pollution = pollution;
            Pollution_type = pollution_type;
        }
        public IRec Clone()
        {
            return new RecNoPul(this.Id, this.Date, this.Pollution, this.Pollution_type);
        }
        public void GetInfo()
        {
            Console.WriteLine($"Rec without pollution with {Id} id");
        }
    }
}
