using UnityEngine;

namespace MS.Casual.Ads
{
	[CreateAssetMenu(fileName = "BannerAdObject", menuName = "ScriptableObjects/Ads/BannerAdObject")]
	public class BannerAdObject : BaseAdsObject
	{
		[SerializeField]
		private ScoreSystem _scoreSystem;

		private bool _showAfterInter;

		public override void Initialize(IAdNetwork adNetwork)
		{
		}

		private void InitializeEvents()
		{
		}

		public override bool IsAdUnlocked()
		{
			return false;
		}

		public override bool CanShowAd()
		{
			return false;
		}

		private void LoadBanner()
		{
		}

		private void OnAdLoaded(string adUnit, MaxSdkBase.AdInfo adInfo)
		{
		}

		public void ShowAdAfterInter()
		{
		}

		public override bool ShowAd(AdEventData adEventData)
		{
			return false;
		}

		public override void HideAd(AdEventData adEventData)
		{
		}

		public override bool IsAdLoaded()
		{
			return false;
		}

		private void ShowBanner(string placement)
		{
		}
	}
}
