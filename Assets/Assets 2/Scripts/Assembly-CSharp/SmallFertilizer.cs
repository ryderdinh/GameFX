using UnityEngine;

[CreateAssetMenu(fileName = "SmallFertilizer", menuName = "ScriptableObjects/Boosters/SmallFertilizer")]
public class SmallFertilizer : Boosters
{
	[SerializeField]
	private SmallFertilizerViewConfig _configs;

	private BoosterSmallFertilizer _smallFertilizer;

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
