using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PitchFork", menuName = "ScriptableObjects/Boosters/PitchFork")]
public class PitchFork : Boosters
{
	[SerializeField]
	private PitchForkViewConfig _configs;

	private PitchForkProductionObject _pitchForkProductionObject;

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
}
