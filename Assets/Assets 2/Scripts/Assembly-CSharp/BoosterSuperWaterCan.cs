using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class BoosterSuperWaterCan : BaseBoosterProductionObject
{
	[SerializeField]
	private GameObject _waterParticles;

	[SerializeField]
	private SkinnedMeshRenderer _renderer;

	private Sequence _waterCanSequence;

	private SuperWaterCanViewConfig _configs;

	public void Initialize(SuperWaterCanViewConfig configs)
	{
	}

	private void PlayWaterCanSequence(Transform transform, Vector3 slot1, List<bool> slots)
	{
	}

	private Sequence SlotsPath(List<Vector3> positions)
	{
		return null;
	}

	private void ResetTransform(Transform transform)
	{
	}

	private void PlayWaterSequence()
	{
	}

	private void PlayWaterParticles()
	{
	}

	private void SetWaterParticleState(bool state)
	{
	}

	private void SetBlendShapeWeight(float value)
	{
	}

	public override void PlayBoosterProduction(Transform transform, Vector3 finalPosition, List<bool> slots)
	{
	}
}
