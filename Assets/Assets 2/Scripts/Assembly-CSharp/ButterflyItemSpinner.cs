using UnityEngine;

public class ButterflyItemSpinner : ItemSpinner
{
	[SerializeField]
	private WatchAdButton _spinButton;

	protected override void RegisterEvents()
	{
	}

	public override void UpdateState()
	{
	}

	protected override void AdShown(bool result)
	{
	}

	public override void SetRvIconState(bool state)
	{
	}
}
