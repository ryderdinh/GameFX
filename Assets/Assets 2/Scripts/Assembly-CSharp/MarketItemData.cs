using UnityEngine;

[CreateAssetMenu(menuName = "Market/New Item", fileName = null)]
public class MarketItemData : InAppItemData
{
	public bool IsStarterPack;

	public int Coins;

	public bool RemoveAds;

	public int SkipAds;

	public CardsItemData CardsItemData;
}
