using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Bomb", menuName = "ScriptableObjects/Boosters/Bomb")]
public class Bomb : Boosters
{
	[SerializeField]
	private BombViewConfig _configs;

	private BombProductionObject _bombProductionObject;

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

	public override void OnShowBoosterProduction(List<Vector3> pos)
	{
	}
}
