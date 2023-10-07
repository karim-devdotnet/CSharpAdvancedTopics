﻿namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encode video...");
            System.Threading.Thread.Sleep(3000);

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