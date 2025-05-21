using System;
using UnityEngine;

public class CardsOffersController : BaseOfferController
{
	public CardsOffersController(MonoBehaviour mono)
		: base(null)
	{
	}

	public override void ShowOfferOnLaunch()
	{
	}

	public override void ShowOfferOnResume()
	{
	}

	public override void ShowFullScreenOffer(Action callBack = null)
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

	private void ShowCardsOffer(bool isInGame, Action callBack = null)
	{
	}
}
