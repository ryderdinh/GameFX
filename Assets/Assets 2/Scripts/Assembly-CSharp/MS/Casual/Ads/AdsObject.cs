using UnityEngine;

namespace MS.Casual.Ads
{
	[CreateAssetMenu(fileName = "AdsObject", menuName = "ScriptableObjects/Ads/AdsObject")]
	public class AdsObject : ScriptableObject, IRemoveAds
	{
		[SerializeField]
		private InterstitialAdObject _interstitialAdObject;

		[SerializeField]
		private InGameInterstitialAdObject _inGameInterstitialAdObject;

		[SerializeField]
		private BannerAdObject _bannerAdObject;

		[SerializeField]
		private RewardedAdObject _rewardedAdObject;

		[SerializeField]
		private RemoveAdsObject _removeAdsController;

		[SerializeField]
		private BloomPassNoAdsPerk _bloomPassNoAdsPerk;

		public void Initialize(IAdNetwork adNetwork, MonoBehaviour monoBehaviour)
		{
		}

		public void ResetAdsTimer(bool hardReset)
		{
		}

		private void InitializeEvents()
		{
		}

		private bool IsRvLoaded()
		{
			return false;
		}

		private bool ShowAd(AdEventData adEventData)
		{
			return false;
		}

		private void HideAd(AdEventData adEventData)
		{
		}

		void IRemoveAds.RemoveAdsPurchased()
		{
		}
	}
}
