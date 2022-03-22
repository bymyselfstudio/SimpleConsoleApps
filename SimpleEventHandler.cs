using System;
					
public class Program
{
	///<summary>
	///Figuring out how events work.
	///<summary/>
	public static void Main()
	{
		Uploader uploader = new Uploader();
		Messenger messenger = new Messenger();
		uploader.SomeThingHappened += messenger.SomeThingHappened;
		uploader.SomeThingHappens();
		uploader.SomeThingHappened -= messenger.SomeThingHappened;
	}
}

delegate void EventHandler(); 

struct Uploader
{
	public event EventHandler SomeThingHappened;
	
	public void SomeThingHappens()
	{
		Console.WriteLine("Something happens");
		SomeThingHappened();
	}
}

struct Messenger
{
	public void SomeThingHappened()
	{
		Console.WriteLine("The event has occured");
	}
}
	
