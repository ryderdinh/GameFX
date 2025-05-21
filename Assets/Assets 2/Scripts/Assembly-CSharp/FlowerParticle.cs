using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class FlowerParticle : MonoBehaviour
{
	[SerializeField]
	private Image _flower;

	[SerializeField]
	protected GameObject _flowerObj;

	[SerializeField]
	protected Transform _flowerTransform;

	protected Sequence _flowerSequence;

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

	public virtual void PlayAnimation(Vector3 endPoint, float duration, Action callback, Vector3 scale, float delay = 0f, bool isWorld = false, float coinsSpreadTime = 0.3f, float coinsSpreadDistance = 300f, float delayAfterSpread = 0.1f)
	{
	}

	public void SetFlowerSprite(Sprite sprite)
	{
	}

	private void SetState(bool state)
	{
	}
}
