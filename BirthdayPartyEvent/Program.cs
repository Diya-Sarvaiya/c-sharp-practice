using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayPartyEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Present() {PresentName = "Lunch Box" };
            var presentNotify = new PresentNotify();
            var giftGiver = new GiftGiver();

            presentNotify.PresentArrival += giftGiver.GiftOpen;
            presentNotify.PresentArrival += giftGiver.TakePicture;

            presentNotify.Present(p1.PresentName);
            Console.ReadLine();

        }

    }
}
