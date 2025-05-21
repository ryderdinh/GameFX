using Core.Server;
using UnityEngine;

public class AppConfig : ScriptableObject
{
	public int AppTargetFrameRate;

	public float AppLoadingTime;

	public float LoadingEndWait;

	[Header("In App Purchases")]
	public InAppProduct[] Products;

	[Header("Remove Ads")]
	public InAppProduct StarterPackProduct;

	[Header("Max Ad Network")]
	public string RewardedAdUnitIdAndroid;

	public string RewardedAdUnitIdIos;

	public string InterstitialAdUnitIdAndroid;

	public string InterstitialAdUnitIdIos;

	public string BannerAdUnitIdAndroid;

	public string BannerAdUnitIdIos;

	[Header("Amazon Ad Network")]
	public string AppUnitIdAndroidAmazon;

	public string AppUnitIdIosAmazon;

	public string RewardedAdUnitIdAndroidAmazon;

	public string RewardedAdUnitIdIosAmazon;

	public string InterstitialAdUnitIdAndroidAmazon;

	public string InterstitialAdUnitIdIosAmazon;

	public string BannerAdUnitIdAndroidAmazon;

	public string BannerAdUnitIdIosAmazon;

	[Header("Server")]
	public UserProgress UserProgress;

	[Header("SkipItOffer")]
	public InAppProduct SkipItOfferProduct;

	public string InterstitialAdUnit => null;

	public string RewardedAdUnit => null;

	public string BannerAdUnit => null;

	public string AppUnitIDAmazon => null;

	public string InterstitialAdUnitAmazon => null;

	public string RewardedAdUnitAmazon => null;

	public string BannerAdUnitAmazon => null;
}
