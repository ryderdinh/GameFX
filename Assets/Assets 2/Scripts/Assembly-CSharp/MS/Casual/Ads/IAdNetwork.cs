using System;

namespace MS.Casual.Ads
{
	public interface IAdNetwork
	{
		void Initialize();

		void LoadRewardedAd();

		bool IsRewardedAdLoaded();

		void ShowRewardedAd(string placement, Action<bool> callback);

		bool IsInterstitialAdLoaded();

		void ShowInterstitial(string placement);

		void ShowBanner(string placement);

		void HideBanner(string placement);
	}
}
