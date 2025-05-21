using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WheelBarrow", menuName = "ScriptableObjects/Boosters/WheelBarrow")]
public class WheelBarrow : Boosters
{
	[SerializeField]
	private WheelBarrowViewConfigs _configs;

	private WheelBarrowProductionObject _productionObject;

	public override void OnShowBoosterProduction(Vector3 pos)
	{
	}

	public new float OnShowBoosterProduction(List<Slot> slots)
	{
		return 0f;
	}

	public override void BoosterExecuted()
	{
	}

	public override bool OnBoosterClick(BoosterViewInfo boosterViewInfo)
	{
		return false;
	}
}
