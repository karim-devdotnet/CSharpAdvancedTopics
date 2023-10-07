// See https://aka.ms/new-console-template for more information
using EventsAndDelegates;

Console.WriteLine("--- Events and Delegates");
var video = new Video { Title = "Video 1" };
var videoEncoder = new VideoEncoder();  // Publisher
var mailService = new MailService(); // Subscriber
var messageService = new MessageService(); // Subscriber

videoEncoder.VideoEncoded += mailService.OnVideoEncoded; //Subscription
videoEncoder.VideoEncoded += messageService.OnVideoEncoded; //Subscription

videoEncoder.Encode(video);

