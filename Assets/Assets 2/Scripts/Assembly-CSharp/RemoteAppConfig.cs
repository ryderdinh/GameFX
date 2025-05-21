using MS.Casual.AB;
using UnityEngine;

public class RemoteAppConfig : ScriptableObject
{
	[Header("Mandatory Update Version")]
	public int MinBuildVersionAndroid;

	public int MinBuildVersionIOS;

	[Header("Ads")]
	public int MinLevelToShowAd;

	[Header("Interstitial Ad")]
	public bool CanShowInterstitialAds;

	public bool CanShowInterstitialOnHomeButton;

	public bool CanShowInterstitialOnPlayButton;

	public bool CanShowInterstitialOnLevelFail;

	public bool CanShowInterstitialOnLevelComplete;

	public int MinScoreToShowInterstitial;

	public int InterstitialUnlockScore;

	public int InterstitialAdDelay;

	[Header("Banner Ad")]
	public bool CanShowBannerAd;

	public int MinScoreToShowBanner;

	public int BannerUnlockScore;

	[Header("In Game Interstitial Ad")]
	public bool CanShowInGameInterstitialAds;

	public int MinScoreToShowInGameInterstitialAds;

	public int InGameInterstitialUnlockScore;

	public int[] InGameInterstitialAdsDelay;

	public int[] InGameInterstitialAdsPotsToPlace;

	public float InGameInterstitialAdsLoadingTime;

	[Header("Firebase")]
	public FirebaseRemoteData FirebaseRemoteData;

	[Header("IAP Verification")]
	public bool SkipAndroidIAPVerification;

	public bool SkipIOSIAPVerification;

	[Header("Butterfly Configs")]
	public bool CanShowNewButterflyFlow;

	public string BucketName;

	public string ExperimentName;

	[Header("Grid Pre Population")]
	public bool CanPrePopulateBoard;

	[Header("IAP Offers")]
	public bool CanActivateCooldownForOffers;

	public int IAPOfferCooldownTime;

	[Header("Revive")]
	public int MaxRevivesThroughAdOnFail;
}
