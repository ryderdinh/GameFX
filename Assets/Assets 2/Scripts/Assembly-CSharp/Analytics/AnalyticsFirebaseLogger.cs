using UnityEngine;

namespace Analytics
{
	[CreateAssetMenu(fileName = "AnalyticsFirebaseLogger", menuName = "Analytics/AnalyticsFirebaseLogger")]
	public class AnalyticsFirebaseLogger : ScriptableObject
	{
		private const string _interWatchedPrefix = "interstitial_show_";

		private const string _rvWatchedPrefix = "rv_show_";

		private const string _shopCompletePrefix = "shop_compelte_";

		public void InterstitialAdWatched(int count)
		{
		}

		public void RewardedVideoWatched(int count)
		{
		}

		public void LogAdRevenueEvent(MaxSdkBase.AdInfo adInfo)
		{
		}

		public void InAppPurchased()
		{
		}

		public void LevelStart()
		{
		}

		public void LevelFail()
		{
		}

		public void ShopComplete(int shopId)
		{
		}

		public void FirstAppOpen()
		{
		}

		public void LevelComplete(int levelId)
		{
		}

		public void ButterflyShown()
		{
		}

		public void ButterflyClicked()
		{
		}

		public void ButterflyUsed(BoostersTypes boosterType)
		{
		}

		private void LogFirebaseEvent(string eventCode)
		{
		}
	}
}
