using UnityEngine;

public class TrailCollectable : MonoBehaviour
{
	[SerializeField]
	private GameObject _streakParticles;

	[SerializeField]
	private RectTransform _transform;

	[SerializeField]
	private ParticleSystem _smokeTrail;

	[SerializeField]
	private ParticleSystem _smokeHead;

	public RectTransform Transform => null;

	public void UpdateStreakParticleState(int itemId, bool updateColor = true)
	{
	}

	public void UpdateParticleColor(Color color)
	{
	}

	private void UpdateParticleColor(int itemID)
	{
	}

	private void SetStreakState(bool state)
	{
	}
}
