using System.Collections.Generic;

namespace MS.Casual.Ads
{
	public static class LionInterstitialAnalyticsWrapper
	{
		private const string SoftCurrencyKey = "current_soft_balance";

		private const string UserLevelKey = "player_level";

		private const string MissionTypeKey = "mission_type";

		private static int? _missionId;

		private static Dictionary<string, object> _additionalData;

		public static void InterstitialShow(string placement)
		{
		}

		public static void InterstitialStart(string adUnit, MaxSdkBase.AdInfo adInfo)
		{
		}

		public static void InterstitialShowFail(string adUnit, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
		{
		}

		public static void InterstitialLoad(string adUnit, MaxSdkBase.AdInfo adInfo)
		{
		}

		public static void InterstitialLoadFail(string adUnit, MaxSdkBase.ErrorInfo errorInfo)
		{
		}

		public static void InterstitialClick(string adUnit, MaxSdkBase.AdInfo adInfo)
		{
		}

		public static void InterstitialEnd(string adUnit, MaxSdkBase.AdInfo adInfo)
		{
		}

		private static void SetInterstitialData()
		{
		}
	}
}
