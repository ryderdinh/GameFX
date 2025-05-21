using System;
using UnityEngine;

public class LiveOpsOfferController : BaseOfferController
{
	private LiveOpsSystem _liveOpsSystem;

	public LiveOpsOfferController(MonoBehaviour mono)
		: base(null)
	{
	}

	protected override void Initialize()
	{
	}

	public void ShowFullScreenOfferOnAd()
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

	private void ShowLiveOpsOffer(bool inGameOffer, Action callBack = null)
	{
	}

	protected override void InitializeOffers()
	{
	}

	protected override void OfferClaimed(bool isRestore)
	{
	}

	protected override void LoadAvailableOffer()
	{
	}

	protected override SpecialOfferItemData GetOfferAgainstIndex(int index)
	{
		return null;
	}
}
