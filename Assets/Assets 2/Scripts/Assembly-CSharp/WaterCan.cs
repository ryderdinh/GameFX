using UnityEngine;

[CreateAssetMenu(fileName = "WaterCan", menuName = "ScriptableObjects/Boosters/WaterCan")]
public class WaterCan : Boosters
{
	[SerializeField]
	private WaterCanViewConfig _configs;

	private BoosterWaterCan _waterCan;

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
