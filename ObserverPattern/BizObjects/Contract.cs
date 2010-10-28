using System;
using System.Collections.Generic;

namespace ObserverPattern.BizObjects
{
	public class Contract
	{
		private List<Signee> _signees;
		private ContractTracker _tracker;

		public Contract()
		{
			_signees = new List<Signee>();
			_tracker = new ContractTracker();
		}

		public void AddSignee(Signee s)
		{
			_signees.Add(s);

			_tracker.Subscribe(s);
			_tracker.UpdateSubscribers(this);
		}

		private PricingPlan _initialPricingPlan;
		public PricingPlan InitialPricingPlan {
			get { return _initialPricingPlan; }
			set
			{
				_initialPricingPlan = value;
				_tracker.UpdateSubscribers(this);
			}
		}
	}
}
