using MS.Casual.Ads;

public struct InterstitialClosedEventData
{
	public AdType AdType;

	public bool IsInGameAd;

	public InterstitialClosedEventData(AdType adType, bool isInGameAd)
	{
		AdType = default(AdType);
		IsInGameAd = false;
	}
}
