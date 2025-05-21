using DG.Tweening;
using UnityEngine;

public class Star : MonoBehaviour
{
	[SerializeField]
	private GameObject _star;

	[SerializeField]
	private Transform _starTransform;

	private Sequence _starSequence;

	public void Initialize(Vector3 startPosition)
	{
	}

	public Sequence Move(Vector3 position, float delay = 0f)
	{
		return null;
	}

	private void SetState(bool state)
	{
	}
}
