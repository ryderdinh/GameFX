using DG.Tweening;
using UnityEngine;

public class BoosterWaterCan : BaseBoosterProductionObject
{
	[SerializeField]
	private GameObject _waterParticles;

	[SerializeField]
	private SkinnedMeshRenderer _renderer;

	private Sequence _waterCanSequence;

	private WaterCanViewConfig _configs;

	public void Initialize(WaterCanViewConfig configs)
	{
	}

	private void PlayWaterCanSequence(Transform transform, Vector3 pos)
	{
	}

	private void ResetTransform(bool isLeft)
	{
	}

	private void PlayWaterSequence()
	{
	}

	private void PlayWaterParticles()
	{
	}

	private void SetWaterCanState(bool state)
	{
	}

	private void SetWaterParticleState(bool state)
	{
	}

	private void SetBlendShapeWeight(float value)
	{
	}

	public override void PlayBoosterProduction(Transform transform, Vector3 finalPosition)
	{
	}
}
