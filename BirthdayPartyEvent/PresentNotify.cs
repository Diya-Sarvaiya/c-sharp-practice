using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayPartyEvent
{
    class PresentNotify
    {
        public delegate void PresentArrivalEventHandler(string PresentName);

        public event PresentArrivalEventHandler PresentArrival;

        public void Present(string PresentName)
        {
            Console.WriteLine("Present Arrived...");
            OnPresentArrival(PresentName);
        }

        public void OnPresentArrival(string PresentName)
        {
            PresentArrival(PresentName);
        }

    }
}
