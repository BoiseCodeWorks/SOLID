using System;
using System.Collections.Generic;

namespace Solid
{
	public class Network
	{
		private INotifier notifier;
		public List<Subscriber> Subscribers { get; set; }

		public Network(INotifier notifier)
		{
			this.notifier = notifier;
			Subscribers = new List<Subscriber>();
		}

		public void SendNotification(string message)
		{
			notifier.Send(Subscribers, message);
		}
	}
}