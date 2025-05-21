using System;

namespace MS.Casual.Market
{
	public class OfferCooldownTimeController
	{
		private string _offerType;

		private double _coolDownTime;

		public bool IsAvailable => false;

		public TimeSpan RemainingTime => default(TimeSpan);

		public void ResetTimer()
		{
		}

		private DateTime GetStartTime()
		{
			return default(DateTime);
		}

		private TimeSpan GetRemainingTime()
		{
			return default(TimeSpan);
		}

		public OfferCooldownTimeController(string offerType, double coolDownTime)
		{
		}
	}
}
