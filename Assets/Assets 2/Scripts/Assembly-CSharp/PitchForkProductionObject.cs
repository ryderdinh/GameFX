using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class PitchForkProductionObject : BaseBoosterProductionObject
{
	[SerializeField]
	private GameObject _trowelObj;

	private Sequence _trowelSequence;

	private PitchForkViewConfig _configs;

	public void Initialize(PitchForkViewConfig configs)
	{
	}

	private void PitchForkSequence(Transform transform, List<Vector3> finalPosition)
	{
	}

	private List<Vector3> CalculatePath(Vector3 startPoint, Vector3 endPoint)
	{
		return null;
	}

	public override void PlayBoosterProduction(Transform transform, List<Vector3> finalPosition)
	{
	}

	private void SetPitchForkState(bool state)
	{
	}
}
