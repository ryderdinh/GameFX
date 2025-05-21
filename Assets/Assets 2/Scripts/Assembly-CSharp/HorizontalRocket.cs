using UnityEngine;

[CreateAssetMenu(fileName = "HorizontalRocket", menuName = "ScriptableObjects/Boosters/HorizontalRocket")]
public class HorizontalRocket : Boosters
{
	[SerializeField]
	private HorizontalRocketViewConfig _configs;

	private HorizontalBoosterShear _shear;

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
