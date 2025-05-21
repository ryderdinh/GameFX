using UnityEngine;

public class PowerUpItemView : Coin
{
	[SerializeField]
	private ParticleSystem _trailParticle;

	[SerializeField]
	private Transform _coinImageRect;

	public ParticleSystem GetTrailParticle()
	{
		return null;
	}

	public Transform GetObjectTransform()
	{
		return null;
	}

	public Transform GetObjectIconRect()
	{
		return null;
	}
}
