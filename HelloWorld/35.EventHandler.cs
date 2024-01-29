using System;
namespace HelloWorld
{
	//public delegate void CompressionHandler(object source, EventArgs e);
	

	public class MyFile
	{
		private string _filePath;
		public string FileName { get; } = "Logo.png";

		public MyFile(string filePath)
		{
			_filePath = filePath;
		}
	}

	public class FileEventArgs : EventArgs
	{
		public MyFile MyFile { get; set; }
	}

	public class FileCompressor
	{
		// This can now be used in replacement of the delegate previously declared above for more convinience.
		public event EventHandler<FileEventArgs> FileCompressed;
		//public event CompressionHandler FileCompressed;

		private MyFile _file;

		public MyFile Compress(MyFile file)
		{
            OnFileCompressed(file);

            _file = file;
			return _file;
		}

		protected virtual void OnFileCompressed(MyFile file)
		{
			// Checking if the event is null before invoking it
			FileCompressed?.Invoke(this, new FileEventArgs() { MyFile = file });
		}
	}


	public class PhoneCallService
	{
		public void OnFileCompressed(object sender, FileEventArgs e)
		{
			Console.WriteLine("Phone call made to compressor on video " + e.MyFile.FileName);
		}
	}

	public class TelexService
	{
		public void OnFileCompressed(object sender, FileEventArgs e)
		{
			Console.WriteLine("Telex message sent to compressor on video " + e.MyFile.FileName);
		}
	}
}

/* This is an Extension on top of the original way of creating an event. In this approach,
 * instead of espressly creating a delegate, we make use of the already crated "EventHandler"
 * class, which under the hood, makes use of a delegate, and create an event on top of it
 
	It by default, accepts an object as its source as previously seen internally as its first
   argument, and the EventArgs as its generic argument, which is used as its second argument,
   (if any argument are to be passed.). If no argument is to be passed, the generic argument
  of EventArgs can be omitted.

   To pass arguments to the subscribers, a custom event argument (eg FileEventArgs as seen above)
  Inherits fromt he "EventArgs" class, and specifies the kind of argument to be received as its
  property. This derived event argument is then used as the generic type of the event.
 
   The method that ececutes the event receives a property of the type specified in the derived
  event argument class, and pass the event argument derivation crated to the event, the method
  further passing the argument it receives in the creation of a new instance of the event
  argument.

   The subscribers can then received the derived event argument instead of the default "EventArgs"
  And then access the properties defined in the derived class as its argument. */