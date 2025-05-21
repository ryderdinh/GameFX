using System;
using DG.Tweening;
using MSKit.ResourcePool;
using UnityEngine;
using UnityEngine.UI;

public class BoostersAnimationController
{
	private Image _boostImage;

	private Transform _imageParent;

	private Vector3 _initialScale;

	private Sequence _sequence;

	private Pool<Image> _boostPool;

	public BoostersAnimationController(Transform poolParent, Image image)
	{
	}

	public void AnimateBooster(int count, Vector3 startPoint, Vector3 targetPoint, ParticleSystem trail, Action callBack, float movementDelay)
	{
	}

	private void AnimateBoost(Vector3 startPoint, Vector3 endPoint, int boostsToAnimate, ParticleSystem trail, Action callBack = null, float movementDelay = 0f)
	{
	}
}
