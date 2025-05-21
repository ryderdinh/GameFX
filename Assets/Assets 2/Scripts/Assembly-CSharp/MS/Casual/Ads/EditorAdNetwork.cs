using System;

namespace MS.Casual.Ads
{
	public class EditorAdNetwork : IAdNetwork
	{
		public void Initialize()
		{
		}

		void IAdNetwork.Initialize()
		{
		}

		void IAdNetwork.LoadRewardedAd()
		{
		}

		bool IAdNetwork.IsRewardedAdLoaded()
		{
			return false;
		}

		void IAdNetwork.ShowRewardedAd(string placement, Action<bool> callback)
		{
		}

		bool IAdNetwork.IsInterstitialAdLoaded()
		{
			return false;
		}

		void IAdNetwork.ShowInterstitial(string placement)
		{
		}

		void IAdNetwork.ShowBanner(string placement)
		{
		}

		void IAdNetwork.HideBanner(string placement)
		{
		}
	}
}
