using System;
using System.Collections.Generic;

namespace Solid
{
	public interface INotifier
	{
		void Send(List<Subscriber> subscribers, string message);
		void Send(Subscriber subscriber, string message);
		void PrintNotification(string tagLine, string message);
	}
}