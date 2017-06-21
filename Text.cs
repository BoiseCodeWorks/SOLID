using System;
using System.Collections.Generic;

namespace Solid
{
	public class Text : IText
	{
		public void Send(List<Subscriber> subscribers, string message)
		{
			foreach(var subscriber in subscribers)
			{
				Send(subscriber, message);
			}
		}

		public void Send(Subscriber subscriber, string message)
		{
			subscriber.Notify(this, message);
		}	

		public void PrintNotification(string tagLine, string message)
		{
			Console.WriteLine(tagLine);
			Console.WriteLine($"Text: {message}");
			Console.WriteLine("");			
		}
	}
}