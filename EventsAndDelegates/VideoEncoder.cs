namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        // 1. Define a delegate
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        // 2. Define an event based on that delegate
        public event VideoEncodedEventHandler VideoEncoded;

        // Instead 1. and 2.
        //public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encode video...");
            System.Threading.Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs { Video = video });
            }
        }
    }

    public class VideoEventArgs : EventArgs
    {
        public required Video Video { get; set; }
    }
}
