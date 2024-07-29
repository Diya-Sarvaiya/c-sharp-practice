using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Event2
{
    class VideoEncoder
    {

        public delegate void VideoEncodedEventHanndler(object source, EventArgs args);

        public event VideoEncodedEventHanndler VideoEncoded;

        public void Encode(video vd)
        {
            Console.WriteLine("video being encoded...");
            Thread.Sleep(3000);

            OnVideoEncoded();
        }
        protected virtual void OnVideoEncoded()
        {
            if(VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }

    }
}
