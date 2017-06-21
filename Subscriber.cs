using System;

namespace Solid
{
	public class Subscriber
	{
		public string Name { get; set; }

		public Subscriber(string name)
		{
			Name = name;
		}

		public virtual void Notify(INotifier notifier, string message)
		{
			notifier.PrintNotification($"Person: {Name}", message);
		}
	}
}