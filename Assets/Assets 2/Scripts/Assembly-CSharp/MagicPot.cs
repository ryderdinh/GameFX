using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MagicPot", menuName = "ScriptableObjects/Boosters/MagicPot")]
public class MagicPot : Boosters
{
	[SerializeField]
	private int ItemId;

	[SerializeField]
	private MagicPotBoosterProductionViewConfig _configs;

	private MagicPotBoosterProductionObject _magicPotBoosterProductionObject;

	public override void BoosterExecuted()
	{
	}

	public override bool OnBoosterClick(BoosterViewInfo boosterViewInfo)
	{
		return false;
	}

	public override void OnShowBoosterProduction(Vector3 pos)
	{
	}

	public void OnShowBoosterProductionMagicPot(List<Slot> cleaningSlots, List<Flower> allRemovedCakes, Collider[] boingColliders, int cakeID, int cakesToRemoveCount)
	{
	}

	public override string GetDescription(int flowerId = 0)
	{
		return null;
	}
}
