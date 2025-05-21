using DG.Tweening;
using UnityEngine;

public class WindBlowerColumnProductionObject : BaseBoosterProductionObject
{
	[SerializeField]
	private ParticleSystem _windParticles;

	[SerializeField]
	private ParticleSystem _windParticles2;

	[SerializeField]
	private Animator _fan;

	private int _fanAnimationId;

	private WindBlowerColumnViewConfigs _configs;

	private Sequence _sequence;

	public void Initialize(WindBlowerColumnViewConfigs configs)
	{
	}

	public override void PlayBoosterProduction(Transform transform, Vector3 finalPosition)
	{
	}

	private void StopFan()
	{
	}

	private void StartFan()
	{
	}

	private void ResetTransform(Transform transform)
	{
	}

	private void PlayWindParticles()
	{
	}

	private void StopWindParticles()
	{
	}
}
