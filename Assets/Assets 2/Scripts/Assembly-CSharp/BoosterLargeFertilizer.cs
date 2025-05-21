using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class BoosterLargeFertilizer : BaseBoosterProductionObject
{
	[SerializeField]
	private GameObject _fertilizerParticles;

	[SerializeField]
	private SkinnedMeshRenderer _mesh;

	[SerializeField]
	private Animator _animator;

	private Transform _meshTransform;

	private Sequence _fertilizerSequence;

	private LargeFertilizerViewConfig _configs;

	public void Initialize(LargeFertilizerViewConfig configs)
	{
	}

	private void PlayFertilizerSequence(Transform transform, List<Vector3> pos)
	{
	}

	public override void PlayBoosterProduction(Transform transform, List<Vector3> pos)
	{
	}

	private void ResetTransform(Transform transform)
	{
	}

	private void SetBlendShapWeight(int id, int weight)
	{
	}

	private void SetBoosterState(bool state)
	{
	}

	private void SetFertilizerParticleState(bool state)
	{
	}
}
