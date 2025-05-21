using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace MS.Casual.AB
{
	public class FirebaseRemoteData : ScriptableObject
	{
		[Header("Remote Strings")]
		[SerializeField]
		private List<FirebaseVariableString> StringValues;

		[Header("Remote Int")]
		[SerializeField]
		private List<FirebaseVariableInt> IntValues;

		[Header("Remote Bool")]
		[SerializeField]
		private List<FirebaseVariableBool> BoolValues;

		[SerializeField]
		[Header("Variables")]
		private int CacheExpirationSecond;

		private bool _isInitialised;

		private bool _isDataFetchingComplete;

		public void Initialise()
		{
		}

		public Task FetchDataAsync()
		{
			return null;
		}

		public bool IsDataFetchingComplete()
		{
			return false;
		}

		private void FetchComplete(Task fetchTask)
		{
		}

		private void GetConfigValues()
		{
		}

		private void SetRemoteUserProperties()
		{
		}

		private Dictionary<string, object> GetDefaultValues()
		{
			return null;
		}

		private bool CanShowBannerAd()
		{
			return false;
		}

		private bool CanShowInGameInterstitialAds()
		{
			return false;
		}

		private bool CanShowInterstitialAds()
		{
			return false;
		}

		private bool CanShowInterstitialOnHomeButton()
		{
			return false;
		}

		private bool CanShowInterstitialOnLevelComplete()
		{
			return false;
		}

		private bool CanShowInterstitialOnLevelFail()
		{
			return false;
		}

		private bool CanShowInterstitialOnPlayButton()
		{
			return false;
		}

		private bool CanShowNewButterflyFlow()
		{
			return false;
		}

		private int InterstitialAdDelay()
		{
			return 0;
		}

		private int MinScoreToShowInGameInterstitialAds()
		{
			return 0;
		}

		private int MinScoreToShowInterstitial()
		{
			return 0;
		}

		private int MinScoreToShowBanner()
		{
			return 0;
		}

		private int InterstitialUnlockScore()
		{
			return 0;
		}

		private int BannerUnlockScore()
		{
			return 0;
		}

		private int InGameInterstitialUnlockScore()
		{
			return 0;
		}

		private int MaxRevivesThroughAdOnFail()
		{
			return 0;
		}

		private int GetMinAppVersionAndroid()
		{
			return 0;
		}

		private int GetMinAppVersionIOS()
		{
			return 0;
		}

		public string GetBucketName()
		{
			return null;
		}

		public string GetExperimentName()
		{
			return null;
		}

		private int[] InGameInterstitialAdsDelay()
		{
			return null;
		}

		private int[] InGameInterstitialAdsPotsToPlace()
		{
			return null;
		}

		private bool CanPrePopulateBoard()
		{
			return false;
		}

		private bool CanActivateCooldownForOffers()
		{
			return false;
		}

		private int IAPOfferCooldownTime()
		{
			return 0;
		}

		private bool CanSkipAndroidIAPVerification()
		{
			return false;
		}

		private bool CanSkipIOSIAPVerification()
		{
			return false;
		}
	}
}
