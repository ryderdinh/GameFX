using DG.Tweening;
using UnityEngine;

public class BoosterSmallFertilizer : BaseBoosterProductionObject
{
	[SerializeField]
	private GameObject _fertilizerParticles;

	[SerializeField]
	private SkinnedMeshRenderer _mesh;

	[SerializeField]
	private Animator _animator;

	private Transform _meshTransform;

	private Sequence _fertilizerSequence;

	private SmallFertilizerViewConfig _configs;

	public void Initialize(SmallFertilizerViewConfig configs)
	{
	}

	public override void PlayBoosterProduction(Transform transform, Vector3 finalPosition)
	{
	}

	private void PlayFertilizerSequence(Transform transform, Vector3 finalPosition)
	{
	}

	private void ResetTransform()
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
