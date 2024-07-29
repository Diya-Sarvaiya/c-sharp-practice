using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event2
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var video = new video() { Title = "Superman" };
            var ven = new VideoEncoder();
            var pub1 = new MailService();
            var pub2 = new MessageService();

            ven.VideoEncoded += pub1.OnVideoEncoded;
            ven.VideoEncoded += pub2.OnVideoEncoded;
            ven.Encode(video);

            Console.ReadKey();
        }
    }
}
