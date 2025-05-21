using System;

public struct CollectableViewTriggerModel
{
	public bool IsOpenInMainMenu;

	public Offers ViewID;

	public MarketPacks MarketPack;

	public Action Callback;

	public IAPOfferContext IAPOfferContext;
}
