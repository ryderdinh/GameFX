using UnityEngine;

[CreateAssetMenu(fileName = "VerticalRocket", menuName = "ScriptableObjects/Boosters/VerticalRocket")]
public class VerticalRocket : Boosters
{
	[SerializeField]
	private VerticalRocketViewConfig _configs;

	private BoosterShear _shear;

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
