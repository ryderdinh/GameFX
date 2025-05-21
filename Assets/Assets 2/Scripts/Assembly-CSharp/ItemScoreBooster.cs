using UnityEngine;

[CreateAssetMenu(fileName = "ItemScoreBooster", menuName = "ScriptableObjects/Boosters/ItemScoreBooster")]
public class ItemScoreBooster : Boosters
{
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
}
