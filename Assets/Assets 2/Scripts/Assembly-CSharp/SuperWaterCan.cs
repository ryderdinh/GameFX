using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SuperWaterCan", menuName = "ScriptableObjects/Boosters/SuperWaterCan")]
public class SuperWaterCan : Boosters
{
	[SerializeField]
	private SuperWaterCanViewConfig _configs;

	private BoosterSuperWaterCan _waterCan;

	public override bool OnBoosterClick(BoosterViewInfo boosterViewInfo)
	{
		return false;
	}

	public override void OnBoosterAdClick()
	{
	}

	public override void OnFreeBoosterClick()
	{
	}

	private void AdShown(bool result)
	{
	}

	public override void OnShowBoosterProduction(Vector3 pos, List<bool> slots)
	{
	}
}
