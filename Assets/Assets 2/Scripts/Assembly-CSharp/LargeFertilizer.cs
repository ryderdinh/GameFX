using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LargeFertilizer", menuName = "ScriptableObjects/Boosters/LargeFertilizer")]
public class LargeFertilizer : Boosters
{
	[SerializeField]
	private LargeFertilizerViewConfig _configs;

	private BoosterLargeFertilizer _largeFertilizer;

	public override void BoosterExecuted()
	{
	}

	public override bool OnBoosterClick(BoosterViewInfo boosterViewInfo)
	{
		return false;
	}

	public override void OnShowBoosterProduction(List<Vector3> pos)
	{
	}

	public override void OnShowBoosterProduction(Vector3 pos)
	{
	}
}
