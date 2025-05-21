using System;
using UnityEngine;

public class CoinsOfferController : BaseOfferController
{
	private bool _isMainMenuOffer;

	public CoinsOfferController(MonoBehaviour mono)
		: base(null)
	{
	}

	public override void ShowOfferOnResume()
	{
	}

	public override void ShowFullScreenOffer(Action callBack = null)
	{
	}

	public override void ShowOfferOnLaunch()
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

	private void ShowSpecialOffer(bool inGameOffer, Action callBack = null)
	{
	}

	protected override void CooldownExpired()
	{
	}

	protected override void LoadCooldownTimer()
	{
	}
}
