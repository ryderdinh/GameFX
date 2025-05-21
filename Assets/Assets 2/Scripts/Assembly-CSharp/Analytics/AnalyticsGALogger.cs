using GameAnalyticsSDK;
using UnityEngine;

namespace Analytics
{
	[CreateAssetMenu(fileName = "AnalyticsGALogger", menuName = "Analytics/AnalyticsGALogger")]
	public class AnalyticsGALogger : ScriptableObject
	{
		private const string GaFirstSessionKey = "GaFirstSessionKey";

		public static void Initialize()
		{
		}

		private static void LogFirstSessionEvent()
		{
		}

		private void LogBusinessIOSEvent(string currency, int amount, string itemType, string itemId, string cartType, string receipt)
		{
		}

		private void LogBusinessAndroidEvent(string currency, int amount, string itemType, string itemId, string cartType, string receipt, string signature)
		{
		}

		private void LogEconomySinkEvent(int amount, string source)
		{
		}

		private void LogEconomySourceEvent(int amount, string source)
		{
		}

		public void LogProgressionEvent(GAProgressionStatus status, string progression01)
		{
		}

		public void LogDesignEvent(string eventName, float eventValue)
		{
		}

		public void LogDesignEvent(string eventName)
		{
		}

		private void LogGARewarded(string placement, GAAdAction adAction, string sdkName)
		{
		}

		private void LogGAInter(string placement, GAAdAction adAction, string sdkName)
		{
		}

		private void LogGAAppOpen(string placement, GAAdAction adAction, string sdkName)
		{
		}

		public void LevelStarted(int level)
		{
		}

		public void LevelFailed(int level, int score)
		{
		}

		public void LevelCompleted(int level, int score)
		{
		}

		public void LogRewardedVideoEvent(string placement)
		{
		}

		public static void LogGARewardedVideoEvent(GAAdAction adAction, string placement)
		{
		}

		public void LogInterstitialShownEvent(string placement)
		{
		}

		public static void LogGAInterstitialVideoEvent(GAAdAction adAction, string placement)
		{
		}
	}
}
