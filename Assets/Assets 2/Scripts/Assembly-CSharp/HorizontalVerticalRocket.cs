using UnityEngine;

[CreateAssetMenu(fileName = "HorizontalVerticalRocket", menuName = "ScriptableObjects/Boosters/HorizontalVerticalRocket")]
public class HorizontalVerticalRocket : Boosters
{
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

	public override void OnShowBoosterProduction(Vector3 pos)
	{
	}
}
