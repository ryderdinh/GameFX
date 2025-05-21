using MSKit.ResourcePool;
using TMPro;
using UnityEngine;

public class StarView : MonoBehaviour
{
	[SerializeField]
	private Star _star;

	[SerializeField]
	private Transform _starContainer;

	[SerializeField]
	private TextMeshProUGUI _starsText;

	[SerializeField]
	private TextMeshProUGUI _starsBgText;

	[SerializeField]
	private ParticleSystem _starsParticle;

	private int _stars;

	private Pool<Star> _starsPool;

	private Pool<ParticleSystem> _particlesPool;

	public void Initialize()
	{
	}

	public void Show(int stars)
	{
	}

	public void PlayStarsSequence(int stars, Vector3 position)
	{
	}

	private void PlayStarParticle(Vector3 position)
	{
	}

	private void SetStarsCount(int stars)
	{
	}
}
