using System;

namespace Solid
{
	public class Business : Subscriber
	{
		public Business(string name) : base(name)
		{

		}
		public override void Notify(INotifier notifier, string message)
		{
			notifier.PrintNotification($"Business: {Name}", message);
		}
	}
}