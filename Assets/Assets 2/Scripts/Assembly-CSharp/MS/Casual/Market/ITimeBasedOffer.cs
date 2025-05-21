using System;

namespace MS.Casual.Market
{
	public interface ITimeBasedOffer
	{
		bool IsAvailable { get; }

		TimeSpan RemainingTime { get; }
	}
}
