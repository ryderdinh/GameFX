using System;
using MSKit.ResourcePool;
using UnityEngine;

public class MarketCardsAnimationView : MonoBehaviour
{
	[SerializeField]
	private ActionButton _activeMenu;

	[SerializeField]
	private RectTransform _container;

	[SerializeField]
	private CardReward _card;

	[SerializeField]
	private Transform _coinContainer;

	[SerializeField]
	private ButtonPressed _playButton;

	[SerializeField]
	private ParticleSystem _splashParticleSystem;

	private Pool<CardReward> _coinPool;

	private Transform _endTransform;

	private Vector3 _endTransformInitialScale;

	public void Initialize(Transform endTransform)
	{
	}

	private void RegisterEvents()
	{
	}

	private void UpdateCardsAnimation(MarketCardsAnimationData cards)
	{
	}

	private void PlayAnimation(Transform skipAdsObject, Vector3 endPoint, float duration, Action callback, Transform skipAdsImage, float delay = 0f)
	{
	}
}
