using System;
using DB;
using UnityEngine;

public class StarterPackController : BaseOfferController
{
	private DBBool _isStarterPackPurchased;

	private DBBool _isStarterPackAvailable;

	public StarterPackController(MonoBehaviour mono)
		: base(null)
	{
	}

	public bool IsStarterPackOfferAvailable()
	{
		return false;
	}

	private void ShowStarterPack(bool isInGame, Action callBack = null)
	{
	}

	public override void ShowOfferOnResume()
	{
	}

	public void ShowFullScreenOfferOnAd()
	{
	}

	public override void ShowFullScreenOffer(Action callBack = null)
	{
	}

	public override void ShowOfferOnLaunch()
	{
	}

	private void RegisterEvents()
	{
	}

	private void StarterPackOfferExpired()
	{
	}

	private bool IsStarterPackPurchased()
	{
		return false;
	}

	private void OnStarterPackPurchased()
	{
	}

	protected override void Initialize()
	{
	}

	protected override void OfferClaimed(bool isRestore)
	{
	}

	protected override void LoadAvailableOffer()
	{
	}

	protected override void LoadNewOffer(bool isPurchased = false)
	{
	}

	protected override void InitializeOffers()
	{
	}

	protected override void OfferExpired()
	{
	}

	protected override void LoadCooldownTimer()
	{
	}

	protected override void CooldownExpired()
	{
	}

	protected override SpecialOfferItemData GetOfferAgainstIndex(int index)
	{
		return null;
	}
}
