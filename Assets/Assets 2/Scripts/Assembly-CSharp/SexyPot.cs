using UnityEngine;

[CreateAssetMenu(fileName = "SexyPot", menuName = "ScriptableObjects/Boosters/SexyPot")]
public class SexyPot : Boosters
{
	public override bool OnBoosterClick(BoosterViewInfo boosterViewInfo)
	{
		return false;
	}

	public override GameObject GetIconPrefab(object data = null)
	{
		return null;
	}

	public override void OnBoosterClose()
	{
	}

	public override void BoosterExecuted()
	{
	}

	public override void OnShowBoosterProduction(Vector3 pos)
	{
	}
}
