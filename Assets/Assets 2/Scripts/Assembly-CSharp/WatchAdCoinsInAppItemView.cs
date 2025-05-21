using MS.Casual.Market;
using UnityEngine;

public class WatchAdCoinsInAppItemView : BaseMarketItemView
{
	[SerializeField]
	private WatchAdButton _watchAdButton;

	[SerializeField]
	private CashObject _cashSystem;

	private void Start()
	{
	}

	protected override void UpdateData()
	{
	}

	public override void OnItemShown()
	{
	}

	private void WatchAdCallBack(bool adShown)
	{
	}

	private void AdShown()
	{
	}
}
