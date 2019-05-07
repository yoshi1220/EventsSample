using System;

namespace EventsSample
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            System.Console.WriteLine($"MessageService: Sending a text message... {e.Video.Title}");
        }
    }
}