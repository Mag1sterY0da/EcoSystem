using Prototype.ConcretePrototypes;
using Prototype.Prototype;

namespace PrototypeProg
{
    class Programm
    {
        static void Main(string[] args)
        {
            IRec rec = new RecPul(133, "04.06.2012", true, "Amiac", 10);
            IRec clonedRec = rec.Clone();
            rec.GetInfo();
            clonedRec.GetInfo();

            rec = new RecNoPul(145, "21.10.2012", false, "Amiac");
            clonedRec = rec.Clone();
            rec.GetInfo();
            clonedRec.GetInfo();

            Console.Read();
        }
    }
}