using System;

namespace ObserverPattern.BizObjects
{
	public class Signee : IObserver<Contract>
	{
		public decimal? CurrentDues { get; set; }

		#region IObserver<Contract> implementation

		public void OnCompleted()
		{
			throw new NotImplementedException();
		}

		public void OnError(Exception error)
		{
			throw new NotImplementedException();
		}

		public void OnNext(Contract value)
		{
			if (value != null
				&& value.InitialPricingPlan != null)
			{
				CurrentDues = value.InitialPricingPlan.Dues;
			}
		}

		#endregion
	}
}
