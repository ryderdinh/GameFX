using System;
using UnityEngine;

[Serializable]
public class LiveOpsOfferItemData
{
	public int WorthCoins;

	public int WorthSkipAds;

	public ResourcesSprite OfferWorthBGSprite;

	public ResourcesSprite OfferFreeBGSprite;

	public Color OfferBGColor;

	public string OfferID;

	public ResourcesSprite GetOfferWorthSprite()
	{
		return null;
	}

	public ResourcesSprite GetOfferFreeBGSprite()
	{
		return null;
	}

	public Color GetOfferBGColor()
	{
		return default(Color);
	}
}
