using DG.Tweening;
using UnityEngine;

public class BoosterShear : BaseBoosterProductionObject
{
	[SerializeField]
	private GameObject _shearObj;

	[SerializeField]
	private Animator _animator;

	private Sequence _shearSequence;

	private VerticalRocketViewConfig _configs;

	public void Initialize(VerticalRocketViewConfig configs)
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

	private void SetShearAnimatorState(bool state)
	{
	}

	private void StartShearAnimator()
	{
	}

	private void ResetShear(Vector3 finalPosition)
	{
	}
}
