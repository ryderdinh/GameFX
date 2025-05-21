using UnityEngine;

namespace MS.Casual.Ads
{
	[CreateAssetMenu(fileName = "RewardedAdObject", menuName = "ScriptableObjects/Ads/RewardedAdObject")]
	public class RewardedAdObject : BaseAdsObject
	{
		public override void HideAd(AdEventData adEventData)
		{
		}

		public override bool IsAdLoaded()
		{
			return false;
		}

		public override bool ShowAd(AdEventData adEventData)
		{
			return false;
		}

		public override bool IsAdUnlocked()
		{
			return false;
		}

		public override bool CanShowAd()
		{
			return false;
		}
	}
}
