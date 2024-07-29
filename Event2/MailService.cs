using System;

namespace Event2
{
    partial class Program
    {
        public class MailService
        {
            public void OnVideoEncoded(Object source , EventArgs e)
            {
                Console.WriteLine("Mail sent..");
            }
        }
    }
}
