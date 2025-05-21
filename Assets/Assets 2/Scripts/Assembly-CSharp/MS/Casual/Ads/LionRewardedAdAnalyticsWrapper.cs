using System.Collections.Generic;

namespace MS.Casual.Ads
{
	public class LionRewardedAdAnalyticsWrapper
	{
		private const string SoftCurrencyKey = "current_soft_balance";

		private const string UserLevelKey = "player_level";

		private const string MissionTypeKey = "mission_type";

		private const string MissionNameKey = "mission_name";

		private const string LevelNumKey = "level_num";

		private const string LimitKey = "limit";

		private const string NumKey = "num";

		private const string LevelType = "level_type";

		private static int? _missionId;

		private static readonly Dictionary<string, object> _additionalData;

		public static void RewardVideoShow(string placement)
		{
		}

		public static void RewardVideoStart(string adUnit, MaxSdkBase.AdInfo adInfo)
		{
		}

		public static void RewardVideoShowFail(string adUnit, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
		{
		}

		public static void RewardVideoLoad(string adUnit, MaxSdkBase.AdInfo adInfo)
		{
		}

		public static void RewardVideoLoadFail(string adUnit, MaxSdkBase.ErrorInfo errorInfo)
		{
		}

		public static void RewardVideoClick(string adUnit, MaxSdkBase.AdInfo adInfo)
		{
		}

		public static void RewardVideoEnd(string adUnit, MaxSdkBase.AdInfo adInfo)
		{
		}

		public static void RewardVideoCollect(string placement, string rewardName, List<PieceSortReward> rewardItems, List<PieceSortReward> virtualCurrencies)
		{
		}

		private static void SetRewardVideoData()
		{
		}
	}
}
