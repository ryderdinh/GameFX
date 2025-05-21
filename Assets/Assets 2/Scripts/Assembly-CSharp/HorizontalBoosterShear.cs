using DG.Tweening;
using UnityEngine;

public class HorizontalBoosterShear : BaseBoosterProductionObject
{
	[SerializeField]
	private GameObject _shearObj;

	private Sequence _shearSequence;

	private HorizontalRocketViewConfig _configs;

	public void Initialize(HorizontalRocketViewConfig configs)
	{
	}

	private void ShearSequence(Transform transform, Vector3 finalPosition)
	{
	}

	public override void PlayBoosterProduction(Transform transform, Vector3 finalPosition)
	{
	}

	private void SetShearState(bool state)
	{
	}

	private void ResetShear(Vector3 finalPosition)
	{
	}
}
