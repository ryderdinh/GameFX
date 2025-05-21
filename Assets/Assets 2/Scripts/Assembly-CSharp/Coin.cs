using System;
using DG.Tweening;
using UnityEngine;

public class Coin : MonoBehaviour
{
	[SerializeField]
	protected GameObject _coinObj;

	[SerializeField]
	protected Transform _coinTransform;

	protected Sequence _coinSequence;

	public Vector3 Position
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 LocalPosition
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public virtual void PlayCoinSequence(Vector3[] path, float duration, Action callback, float delay = 0f, bool isWorld = false, float rotation = 360f)
	{
	}

	public virtual void PlayAnimation(Vector3 endPoint, float duration, Action callback, float delay = 0f, bool isWorld = false, float coinsSpreadTime = 0.3f, float coinsSpreadDistance = 300f, float delayAfterSpread = 0.1f, float rotation = 360f)
	{
	}

	public void SetState(bool state)
	{
	}
}
