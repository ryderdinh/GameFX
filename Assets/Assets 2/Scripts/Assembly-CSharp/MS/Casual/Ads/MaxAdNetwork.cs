using System;

namespace MS.Casual.Ads
{
	public class MaxAdNetwork : IAdNetwork
	{
		private Action<bool> _rewardedVideoCallback;

		private bool _isFirstInitialize;

		[NonSerialized]
		private bool _isLoadingFirstInterstitialAd;

		[NonSerialized]
		private bool _isLoadingFirstRewardedAd;

		void IAdNetwork.HideBanner(string placement)
		{
		}

		void IAdNetwork.Initialize()
		{
		}

		bool IAdNetwork.IsInterstitialAdLoaded()
		{
			return false;
		}

		bool IAdNetwork.IsRewardedAdLoaded()
		{
			return false;
		}

		void IAdNetwork.LoadRewardedAd()
		{
		}

		void IAdNetwork.ShowBanner(string placement)
		{
		}

		void IAdNetwork.ShowInterstitial(string placement)
		{
		}

		void IAdNetwork.ShowRewardedAd(string placement, Action<bool> callback)
		{
		}

		private void MaxInitialized(MaxSdkBase.SdkConfiguration sdkConfiguration)
		{
		}

		private void LoadAmazonInterAd()
		{
		}

		private void LoadAmazonBanner()
		{
		}

		private void CreateMaxBanner()
		{
		}

		private void LoadAmazonRewardedAd()
		{
		}

		private void RewardReceived(string placement, MaxSdkBase.Reward reward, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void LoadInterstitial()
		{
		}

		public void LoadRewarded()
		{
		}
	}
}
