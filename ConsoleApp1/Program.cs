using DAL.Entities;

namespace Facade
{
    class Programm
    {
        static void Main(string[] args)
        {
            var rec1 = new Rec() { Id = 1 };
            var rec2 = new Rec() { Id = 2 };
            var rec3 = new Rec() { Id = 3 };
            var recs = new Rec[] { rec1, rec2, rec3 };
            Lab labA = new Lab() { LabID = 1, Name="Lab1", Recs = recs };
            Lab labB = new Lab() { LabID = 2, Name = "Lab2",Recs = recs };
            Lab labC = new Lab() { LabID = 3, Name = "Lab3", Recs = recs };
            Facade facade = new Facade(labA, labB, labC);
            facade.printLabsNames();
            facade.printRecsFromLabs();
        }
    }
}
