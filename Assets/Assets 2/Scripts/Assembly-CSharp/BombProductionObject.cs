using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class BombProductionObject : BaseBoosterProductionObject
{
	[SerializeField]
	private GameObject _bombObject;

	[SerializeField]
	private Animator _animator;

	[SerializeField]
	private ParticleSystem _particleSystem;

	private Sequence _bombSequence;

	private BombViewConfig _configs;

	public void Initialize(BombViewConfig configs)
	{
	}

	private void BombSequence(Transform transform, List<Vector3> finalPositions)
	{
	}

	private void SetBombObjectState(bool state)
	{
	}

	private List<Vector3> CalculatePath(Vector3 startPoint, Vector3 endPoint, bool addOffset = true, bool addHandleOffset = true)
	{
		return null;
	}

	private void ResetBomb(Transform transform)
	{
	}

	public override void PlayBoosterProduction(Transform transform, List<Vector3> finalPosition)
	{
	}
}
