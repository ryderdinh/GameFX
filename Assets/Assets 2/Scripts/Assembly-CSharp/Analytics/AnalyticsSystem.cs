using System;
using System.Collections.Generic;
using DB;
using MS.Casual.IAP;
using MS.Store;
using UnityEngine;
using UnityEngine.Purchasing;

namespace Analytics
{
	[CreateAssetMenu(fileName = "AnalyticsSystem", menuName = "Analytics/Analytics System")]
	public class AnalyticsSystem : ScriptableObject
	{
		[SerializeField]
		private AnalyticsTracker _tracker;

		[SerializeField]
		private AnalyticsLALogger _laLogger;

		[SerializeField]
		private AnalyticsGALogger _gaLogger;

		[SerializeField]
		private AnalyticsAdjustLogger _adjustLogger;

		[SerializeField]
		private AnalyticsFirebaseLogger _firebaseLogger;

		[SerializeField]
		private DBBool _isFirstAppOpen;

		[SerializeField]
		private DBInt _lastLevelLogged;

		[NonSerialized]
		private bool _isInitialized;

		private bool _canLogTestAdjustEvents;

		private IAPInteractionAnalyticsData _iAPInteractionAnalyticsData;

		private void EnableAdjustTestEvents()
		{
		}

		private void OnEnable()
		{
		}

		public void Initialize()
		{
		}

		public void LogLevelStart(int levelId)
		{
		}

		public void LogLevelFail(int levelId)
		{
		}

		public void LogLevelComplete(int levelId)
		{
		}

		public void LogLevelStepComplete(int levelId)
		{
		}

		private void RegisterEvents()
		{
		}

		private void OnAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo impressionData)
		{
		}

		private void RewardedWatched(string placement, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void RewardedAdRewardReceived(string placement, MaxSdkBase.Reward reward, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void RewardedClicked(string placement, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void RewardedLoaded(string placement, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void RewardedLoadFail(string placement, MaxSdkBase.ErrorInfo errorInfo)
		{
		}

		private void RewardedDisplayFail(string placement, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void RewardedHidden(string placement, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void InterWatched(string placement, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void InterClicked(string placement, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void InterLoaded(string placement, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void InterLoadFailed(string placement, MaxSdkBase.ErrorInfo errorInfo)
		{
		}

		private void InterDisplayFailed(string placement, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void InterHidden(string placement, MaxSdkBase.AdInfo adInfo)
		{
		}

		public void LogUIInteraction(string uiName, string uiAction, string uiPlacement, string uiType, Dictionary<string, object> additionalData = null)
		{
		}

		public void LogShopCompleteEvent(int shopId)
		{
		}

		public void LogButterflyShownEvent()
		{
		}

		public void LogButterflyClickedEvent()
		{
		}

		public void LogButterflyUsedEvent(BoostersTypes boosterType)
		{
		}

		public void UpdateIAPInteraction(IAPOfferContext iAPOfferContext, IAPInteractionType iAPInteractionType)
		{
		}

		private void LogIAPPurchaseSuccess(TransactionRecord product, RestoreStatus restoreStatus, IAPRecordStatus status)
		{
		}

		private void LogIAPPurchase(string productId)
		{
		}

		private void LogIAPPurchaseFail(TransactionRecord product, PurchaseFailureReason reason)
		{
		}

		private void LogIAPVerification(IAPRecordStatus status)
		{
		}
	}
}
