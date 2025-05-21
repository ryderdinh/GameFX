using UnityEngine;

[CreateAssetMenu(fileName = "DishTierUpdate", menuName = "ScriptableObjects/Boosters/DishTierUpdate")]
public class DishTierUpdate : Boosters
{
	public override bool OnBoosterClick(BoosterViewInfo boosterViewInfo)
	{
		return false;
	}

	public override void OnBoosterClose()
	{
	}

	public override void OnShowBoosterProduction(Vector3 pos)
	{
	}

	public override string GetDescription(int flowerId = 0)
	{
		return null;
	}
}
