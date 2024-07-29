using System;

namespace Event2
{
    partial class Program
    {
        public class MessageService
        {
            public void OnVideoEncoded(Object source,EventArgs e)
            {
                Console.WriteLine("Message sent..");
            }
        }
    }
}
