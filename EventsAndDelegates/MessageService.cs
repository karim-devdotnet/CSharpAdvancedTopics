﻿namespace EventsAndDelegates
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MessageService: Sending Message... " + e.Video.Title);
        }
    }
}
