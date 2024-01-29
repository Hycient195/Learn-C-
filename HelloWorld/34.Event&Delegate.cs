using System;
namespace HelloWorld
{
	public class Video
	{
		public string Name { get; set; }
	}

	public class VideoEncoder
	{
        public delegate void VideoEncodedHandler(object source, EventArgs e);

        public event VideoEncodedHandler VideoEncoded;

        public void Encode(Video video)
		{
			if (video == null)
				throw new NullReferenceException("Video instance is null");

			Console.WriteLine($"Encoding video {video.Name}");

			OnVideoEncoded();
		}

		protected virtual void OnVideoEncoded()
		{
			if (VideoEncoded == null)
				throw new NullReferenceException("Null video instance provided");

			VideoEncoded(this, EventArgs.Empty);
		}
	}


	/* Creating the subscribers to the event */
	public class MailingService
	{
		public void OnVideoEncoded(object source, EventArgs e)
		{
			Console.WriteLine("Mail sent ...");
		}
	}

	public class TextMessageService
	{
		public void OnVideoEncoded(object source, EventArgs e)
		{
			Console.WriteLine("Text message sent ...");
		}
	}
}

/* An event is a mechanism used to provide notification in other classes, when an event
 * or action occiurs in another class. The class the send or emits the event is called
 * the "publisher" while the class(es) that receive the event or notification is/are
 * called the "subscribers"
 
	To create an event, follow the steps
  1) Create a delegate, to which the event would be referenced to so that methods can be
	 attached. The delegate accepts a "source" argument with type "object" and an "event"
     property with a type of "EventArgs"

  2) Create an event, and use the delegate crated as its type.

  3) Create a method that executes the event, passing, "this" which is the context of the
     publisher class, and EventArgs.Empty as argumens. Null checks should be performed
     in the method, and the method invoked in method, which would emit or send the event.

  4) Create the subscriber classes and methods to be subscribed.

  5) In the block of code where the publisher and subscribers are to be attached,  Create
     an instance of the publisher and the subscribers

  6) Using the compound assignment operator (+=) assign or subscribe the subscriber
	 methods to the the publisher event

  7) Invoke the method containing the call to the event in the publisher, in order to
     send or emit the events to the subscribers otherwise calling all of the subscriber
     methods.

  8) You could optionally unsubscribe from the event by using the -= operator
*/