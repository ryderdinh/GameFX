using System.Collections.Generic;
using Core.Server;
using LionStudios.Suite.Analytics;
using LionStudios.Suite.Analytics.Events;
using MS.Casual.IAP;
using MS.Store;
using UnityEngine;

namespace Analytics
{
	[CreateAssetMenu(fileName = "AnalyticsLALogger", menuName = "Analytics/LA/LA Logger")]
	public class AnalyticsLALogger : ScriptableObject
	{
		public static class LAParamType
		{
			public static readonly string CurrentStatus;

			public static readonly string LifetimeStatus;

			public static readonly string DeviceTime;

			public static readonly string SkipIts;
		}

		[SerializeField]
		private AnalyticsTracker AnalyticsTracker;

		[SerializeField]
		private UserJourneySystem _userJourneySystem;

		[SerializeField]
		private NakamaServer _nakamaServer;

		[SerializeField]
		private RemoteAppConfig _remoteAppConfig;

		private void SetAnalyticsTopLevelParameters()
		{
		}

		public void LogLevelStart(int levelNumber)
		{
		}

		public void LogLevelStep(int levelNumber)
		{
		}

		public void LogLevelFail(int levelNumber)
		{
		}

		public void LogLevelComplete(int levelNumber)
		{
		}

		public void LogLevelAbandon(int levelNumber)
		{
		}

		public void LogUIInteractionEvent(string uiName, string uiAction, string uiPlacement, string uiType, Dictionary<string, object> additionalData = null)
		{
		}

		public void RewardVideoShowEvent(string placement, MaxSdkBase.AdInfo adInfo)
		{
		}

		public void RewardVideoShowFailEvent(string placement, MaxSdkBase.AdInfo adInfo, MaxSdkBase.ErrorInfo errorInfo)
		{
		}

		public void RewardVideoStartEvent(string placement, MaxSdkBase.AdInfo adInfo)
		{
		}

		public void RewardVideoEndEvent(string placement, MaxSdkBase.AdInfo adInfo)
		{
		}

		public void RewardVideoClickEvent(string placement, MaxSdkBase.AdInfo adInfo)
		{
		}

		public void RewardedAdRewardReceived(string placement, MaxSdkBase.Reward reward, MaxSdkBase.AdInfo adInfo)
		{
		}

		public void RewardVideoLoadEvent(string placement, MaxSdkBase.AdInfo adInfo)
		{
		}

		public void RewardVideoLoadFailedEvent(string placement, MaxSdkBase.ErrorInfo errorInfo)
		{
		}

		public void InterstitialLoadEvent(string placement, MaxSdkBase.AdInfo adInfo)
		{
		}

		public void InterstitialLoadFailEvent(string placement, MaxSdkBase.ErrorInfo errorInfo)
		{
		}

		public void InterstitialShowEvent(string placement, MaxSdkBase.AdInfo adInfo)
		{
		}

		public void InterstitialShowFailEvent(string placement, MaxSdkBase.AdInfo adInfo, MaxSdkBase.ErrorInfo errorInfo)
		{
		}

		public void InterstitialStartEvent(string placement, MaxSdkBase.AdInfo adInfo)
		{
		}

		public void InterstitialEndEvent(string placement, MaxSdkBase.AdInfo adInfo)
		{
		}

		public void InterstitialClickEvent(string placement, MaxSdkBase.AdInfo adInfo)
		{
		}

		public void LogNormalGameInApp(string placement, TransactionRecord product, string intent, IAPRecordStatus status, bool isJailBreak)
		{
		}

		private Product GetProductsReceived(MarketItemData itemData)
		{
			return null;
		}

		private void AddCommonParameters(ref Dictionary<string, object> dictionary)
		{
		}

		private string ConvertDictionaryToString(Dictionary<string, object> dictionary)
		{
			return null;
		}

		private ReceiptStatus GetReceiptStatus(IAPRecordStatus status)
		{
			return default(ReceiptStatus);
		}
	}
}
