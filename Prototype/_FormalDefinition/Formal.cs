using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype._FormalDefinition
{
    class Laborant
    {
        void Operation(int Id, string Date, Boolean Pollution, string Pollution_type, int Pollution_metrics)
        {
            Prototype prototype = new ConcretePrototype1(Id, Date, Pollution, Pollution_type, Pollution_metrics);
            Prototype clone = prototype.Clone();
            prototype = new ConcretePrototype2(Id, Date, Pollution, Pollution_type, Pollution_metrics);
            clone = prototype.Clone();
        }

    }
    public abstract class Prototype
    {
        public int Id { get; private set; }
        public string Date { get; set; }
        public Boolean Pollution { get; set; }
        public string Pollution_type { get; set; }
        public int Pollution_metrics { get; set; }
        public Prototype(int id, string Date, Boolean Pollution, string Pollution_type, int Pollution_metrics)
        {
            this.Id = id;
            this.Date = Date;
            this.Pollution = Pollution;
            this.Pollution_type = Pollution_type;
            this.Pollution_metrics = Pollution_metrics;
        }
        public abstract Prototype Clone();
    }

    public class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(int id, string Date, Boolean Pollution, string Pollution_type, int Pollution_metrics)
            : base(id, Date, Pollution, Pollution_type, Pollution_metrics)
        { }
        public override Prototype Clone()
        {
            return new ConcretePrototype1(Id, Date, Pollution, Pollution_type, Pollution_metrics);
        }
    }
    public class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(int id, string Date, Boolean Pollution, string Pollution_type, int Pollution_metrics = 0)
            : base(id, Date, Pollution, Pollution_type, Pollution_metrics)
        { }
        public override Prototype Clone()
        {
            return new ConcretePrototype1(Id, Date, Pollution, Pollution_type, Pollution_metrics);
        }
    }
}
