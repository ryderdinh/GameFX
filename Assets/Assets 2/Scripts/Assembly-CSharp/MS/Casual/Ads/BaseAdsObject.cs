using UnityEngine;

namespace MS.Casual.Ads
{
	public abstract class BaseAdsObject : ScriptableObject
	{
		[SerializeField]
		protected RemoteAppConfig _remoteAppConfigs;

		protected IAdNetwork _adNetwork;

		public abstract bool ShowAd(AdEventData adEventData);

		public abstract void HideAd(AdEventData adEventData);

		public abstract bool IsAdLoaded();

		public abstract bool IsAdUnlocked();

		public abstract bool CanShowAd();

		public virtual void Initialize(IAdNetwork adNetwork)
		{
		}
	}
}
