using LionStudios.Suite.Core;
using UnityEngine;

[LabelOverride("AppLovin MAX")]
public class LionApplovinMaxSettings : ILionSettingsInfo
{
	[Header("General")]
	public string sdkKey;

	[Header("Rewarded Ads")]
	public string rewardedAdUnitIdAndroid;

	public string rewardedAdUnitIdIos;

	[Header("Interstitial Ads")]
	public string interstitialAdUnitIdAndroid;

	public string interstitialAdUnitIdIos;

	[Header("Banner Ads")]
	public string bannerAdUnitIdAndroid;

	public string bannerAdUnitIdIos;

	[Header("App Open Ads")]
	public string appOpenAdUnitIdAndroid;

	public string appOpenAdUnitIdIos;

	[Header("Cross Promo Ads")]
	public string crossPromoAdUnitIdAndroid;

	public string crossPromoAdUnitIdIos;

	public string InterstitialAdUnit => null;

	public string AppOpenAdUnit => null;

	public string RewardedAdUnit => null;

	public string BannerAdUnit => null;

	public string CrossPromoAdUnit => null;
}
