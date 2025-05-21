using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SuperMagicPot", menuName = "ScriptableObjects/Boosters/SuperMagicPot")]
public class SuperMagicPot : Boosters
{
	[SerializeField]
	private int itemId;

	[SerializeField]
	private SuperMagicPotProductionObjectConfigs _configs;

	private SuperMagicPotProductionObject _superMagicPotBoosterProductionObject;

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

	public override string GetDescription(int flowerId = 0)
	{
		return null;
	}

	public float OnShowBoosterProductionSuperMagicPot(List<Slot> cleaningSlots, List<Flower> allRemovedCakes, Collider[] boingColliders, int cakeID, int cakesToRemoveCount)
	{
		return 0f;
	}
}
