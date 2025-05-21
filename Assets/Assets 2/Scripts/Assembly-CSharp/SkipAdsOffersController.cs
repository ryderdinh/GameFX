using System;
using UnityEngine;

public class SkipAdsOffersController : BaseOfferController
{
	public SkipAdsOffersController(MonoBehaviour mono)
		: base(null)
	{
	}

	public override void ShowOfferOnLaunch()
	{
	}

	public override void ShowFullScreenOffer(Action callBack = null)
	{
	}

	public override void ShowOfferOnResume()
	{
	}

	public void ShowFullScreenOfferOnAd(ISkipAdsPurchaseView model)
	{
	}

	protected override void Initialize()
	{
	}

	protected override void InitializeOffers()
	{
	}

	protected override SpecialOfferItemData GetOfferAgainstIndex(int index)
	{
		return null;
	}

	protected override void CooldownExpired()
	{
	}

	protected override void LoadCooldownTimer()
	{
	}

	private void ShowSkipAdsOffer(bool isInGame, Action callBack = null)
	{
	}
}
