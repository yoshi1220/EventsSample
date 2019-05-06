using System;
using System.Threading;

namespace EventsSample
{
    public class VideoEncoder
    {
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;
        public void Encode(Video video)
        {
            System.Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }
}