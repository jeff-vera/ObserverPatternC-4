using System;
using System.Collections.Generic;

namespace ObserverPattern.BizObjects
{
	public class ContractTracker : IObservable<Contract>
	{
		private List<IObserver<Contract>> _observers;

		public ContractTracker()
		{
			_observers = new List<IObserver<Contract>>();
		}

		public IDisposable Subscribe(IObserver<Contract> observer)
		{
			_observers.Add(observer);

			return null;
		}

		public void UpdateSubscribers(Contract c)
		{
			_observers.ForEach(x => x.OnNext(c));
		}
	}
}
