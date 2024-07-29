using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventAndDelegate
{

    public class Timer
    {
        // Define a delegate for the event
        public delegate void TimeUpHandler();

        // Declare an event of type TimeUpHandler
        public event TimeUpHandler TimeUp;

        // Method to simulate the timer reaching zero
        public void SimulateTimeUp()
        {
            Console.WriteLine("Timer reached zero!");
            Thread.Sleep(3000);
            // Check if there are any subscribers and invoke the event
            TimeUp?.Invoke();
        }
    }

    public class Notifier
    {
        // Method to handle the TimeUp event
        public void OnTimeUp()
        {
            Console.WriteLine("Time's up! Notifying user.");
        }
        public void OnTimeUpDoThis()
        {
            Console.WriteLine("Time's u kjkldsfp! Notifying user.");
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Create instances of Timer and Notifier
            Timer myTimer = new Timer();
            Notifier myNotifier = new Notifier();

            // Subscribe the OnTimeUp method to the TimeUp event
            myTimer.TimeUp += myNotifier.OnTimeUp;
            myTimer.TimeUp += myNotifier.OnTimeUpDoThis;

            // Simulate the timer reaching zero, which will trigger the event
            myTimer.SimulateTimeUp();
        }
    }

}
