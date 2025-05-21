using System;

namespace MS.Casual.Market
{
	public static class OfferState
	{
		private const string OfferRemainingTimeKey = "RemainingTime";

		private const string OfferCooldownRemainingTimeKey = "CooldownRemainingTime";

		private const string OfferIndexKey = "Index";

		private const string OffersPurchasedKeyPostfix = "Purchased";

		public static DateTime GetOfferStartTime(string key)
		{
			return default(DateTime);
		}

		public static void SetOfferStartTime(string key, DateTime value)
		{
		}

		public static DateTime GetOfferCooldownStartTime(string key)
		{
			return default(DateTime);
		}

		public static void SetOfferCooldownStartTime(string key, DateTime value)
		{
		}

		public static int GetOfferIndex(string key, int defaultVal = -1)
		{
			return 0;
		}

		public static void SetOfferIndex(string key, int val)
		{
		}

		public static bool GetOfferPurchased(string key)
		{
			return false;
		}

		public static void SetOfferPurchased(string key, bool val)
		{
		}
	}
}
