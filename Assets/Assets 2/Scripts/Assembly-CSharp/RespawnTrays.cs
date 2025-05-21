using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RespawnTrays", menuName = "ScriptableObjects/Boosters/RespawnTrays")]
public class RespawnTrays : Boosters
{
	[SerializeField]
	private RespawnTraysObjectViewConfigs _configs;

	private RespawnTraysProductionObject _productionObject;

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

	public void OnShowBoosterProduction(List<Tray> trays, Transform trayContainer)
	{
	}
}
