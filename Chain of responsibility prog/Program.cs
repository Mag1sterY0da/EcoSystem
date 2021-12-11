
using Chain_of_responsibility;

namespace Observer
{
    class Programm
    {
        static void Main(string[] args)
        {
            Handler l1 = new LabHandler1();
            Handler l2 = new LabHandler2();
            l1.Successor = l2;
            var i = 1;
            var answer = "";
            while (answer != "Send")
            {
                answer = l1.HandleRequest(i);
                i++;
            }
        }
    }
}