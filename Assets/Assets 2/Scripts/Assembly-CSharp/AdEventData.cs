using System;
using MS.Casual.Ads;

public struct AdEventData
{
	public AdType AdType;

	public string Placement;

	public Action<bool> CallBack;

	public InterstitialType InterstitialType;

	public bool CanShowOfferOnClose;

	public bool ForceShow;

	public bool IsInGameAd;

	public AdEventData(AdType adType, string placement, Action<bool> callBack, InterstitialType interstitialType = InterstitialType.Menu, bool canShowOfferOnClose = true, bool forceShow = false, bool isInGameAd = false)
	{
		AdType = default(AdType);
		Placement = null;
		CallBack = null;
		InterstitialType = default(InterstitialType);
		CanShowOfferOnClose = false;
		ForceShow = false;
		IsInGameAd = false;
	}
}
