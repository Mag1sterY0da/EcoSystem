using DAL.Entities;
using Facade.Labs;

namespace Facade
{
    class Programm
    {
        static void Main(string[] args)
        {
            var rec = new Rec() { Id = 1 };
            var recs = new Rec[] { rec, rec, rec };
            LabA labA = new LabA() { LabID = 1, Recs = recs };
            LabB labB = new LabB() { LabID = 1, Recs = recs };
            LabC labC = new LabC() { LabID = 1, Recs = recs };
            Facade facade = new Facade(labA, labB, labC);
            facade.Operation2();

        }
    }
}
