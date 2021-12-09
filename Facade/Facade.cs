using DAL.EF;
using DAL.Entities;
using DAL.Repositories.Impl;
using Microsoft.EntityFrameworkCore;

namespace Facade
{
    public class Facade
    {
        Lab labA;
        Lab labB;
        Lab labC;

        public Facade(Lab la, Lab lb, Lab lc)
        {
            labA = la;
            labB = lb;
            labC = lc;
        }
        public void printLabsNames()
        {
            string names = labA.Name+ " " + labB.Name + " " + labC.Name;
            Console.WriteLine(names);
        }
        public void printRecsFromLabs()
        {
            var tAllRecs = new Rec[] { };
            var AllRecs = tAllRecs.ToList();
            foreach (var i in labA.Recs)
            {
                AllRecs.Add(i);
            }
            foreach (var i in labB.Recs)
            {
                AllRecs.Add(i);
            }
            foreach (var i in labC.Recs)
            {
                AllRecs.Add(i);
            }
            foreach (var i in AllRecs)
            {
                Console.WriteLine(i.Id);
            }
        }
    }
}