using Prototype.Prototype;
using System;

namespace Prototype.ConcretePrototypes
{
    public class RecPul : IRec
    {
        public int Id { get; private set; }
        public string Date { get; set; }
        public Boolean Pollution { get; set; }
        public string Pollution_type { get; set; }
        public int Pollution_metrics { get; set; }

        public RecPul(int id, string date, Boolean pollution, string pollution_type, int pollution_metrics)
        {
            Id = id;
            Date = date;
            Pollution = pollution;
            Pollution_type = pollution_type;
            Pollution_metrics = pollution_metrics;            
        }
        public IRec Clone()
        {
            return new RecPul(this.Id, this.Date, this.Pollution, this.Pollution_type, this.Pollution_metrics);
        }
        public void GetInfo()
        {
            Console.WriteLine($"Pollution rec with {Id} id");
        }
    }
}
