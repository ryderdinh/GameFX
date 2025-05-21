using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SwapSlots", menuName = "ScriptableObjects/Boosters/SwapSlots")]
public class SwapSlots : Boosters
{
	[SerializeField]
	private SwapSlotsViewConfig _configs;

	private BoosterSwapSlots _gloves;

	public override bool OnBoosterClick(BoosterViewInfo boosterViewInfo)
	{
		return false;
	}

	public override void OnBoosterClose()
	{
	}

	public override void BoosterExecuted()
	{
	}

	public override void OnShowBoosterProduction(List<Slot> slots)
	{
	}
}
