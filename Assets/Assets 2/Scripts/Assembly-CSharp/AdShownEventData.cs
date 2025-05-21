using MS.Casual.Ads;

public struct AdShownEventData
{
	public AdType AdType;

	public string Placement;

	public AdShownEventData(AdType adType, string placement)
	{
		AdType = default(AdType);
		Placement = null;
	}
}
