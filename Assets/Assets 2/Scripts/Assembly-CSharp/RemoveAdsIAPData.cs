using System;

[Serializable]
public struct RemoveAdsIAPData
{
	public InAppProduct RemoveAdsProduct;

	public MarketItemData MarketItemData;

	public int WorldToActivate;

	public int MinIntersToActivate;

	public float DiscountPercentage;
}
