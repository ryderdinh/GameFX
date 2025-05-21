using System;

namespace MS.Casual.Market
{
	public class SpecialOfferTimeController : ITimeBasedOffer
	{
		private SpecialOfferItemData _itemData;

		private string _offerType;

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

		public SpecialOfferTimeController(SpecialOfferItemData data)
		{
		}
	}
}
