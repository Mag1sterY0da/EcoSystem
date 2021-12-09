using Observer;

namespace Facade
{
    class Programm
    {
        static void Main(string[] args)
        {
            var Enter1 = new EnterpriceObserver();
            var Enter2 = new EnterpriceObserver();
            var Enter3 = new EnterpriceObserver();
            Console.WriteLine(Enter1.isTimeToSendRecs);
            Console.WriteLine(Enter2.isTimeToSendRecs);
            Console.WriteLine(Enter3.isTimeToSendRecs);
            var Observ = new Observable();
            Observ.AddObserver(Enter1);
            Observ.AddObserver(Enter2);
            Observ.AddObserver(Enter3);
            Observ.NotifyObservers();
            Console.WriteLine(Enter1.isTimeToSendRecs);
            Console.WriteLine(Enter2.isTimeToSendRecs);
            Console.WriteLine(Enter3.isTimeToSendRecs);
        }
    }
}