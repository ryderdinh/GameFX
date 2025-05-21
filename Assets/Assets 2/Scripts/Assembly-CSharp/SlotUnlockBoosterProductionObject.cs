using UnityEngine;

public class SlotUnlockBoosterProductionObject : BaseBoosterProductionObject
{
	[SerializeField]
	private ParticleSystem _dustParticles;

	[SerializeField]
	private Animator _keyAnimator;

	private SlotUnlockBoosterViewConfigs _configs;

	public void Initialize(SlotUnlockBoosterViewConfigs configs)
	{
	}

	public override void PlayBoosterProduction(Transform transform, Vector3 finalPosition)
	{
	}

	private void ResetTransform(Transform transform)
	{
	}

	private void SetState(bool state)
	{
	}
}
