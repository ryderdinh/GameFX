using System;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpAnimationView : MonoBehaviour
{
	[SerializeField]
	private ActionButton _activeMenu;

	[SerializeField]
	private RectTransform _container;

	public Transform EndTransform;

	public ButtonPressed PlayButton;

	public PowerUpItemView Sprayer;

	public PowerUpItemView BrushCutter;

	public PowerUpItemView WheelsBarrow;

	[SerializeField]
	private ParticleSystem _splashParticleSystem;

	private Dictionary<BoostersTypes, PowerUpItemView> _powerUps;

	private Dictionary<BoostersTypes, Vector3> _initialPositions;

	private Dictionary<BoostersTypes, Vector3> _initialScales;

	private Vector3 _endTransformInitialScale;

	public void Initialize()
	{
	}

	private void InitializePowerUpsDictionary()
	{
	}

	private void CacheInitialPositions()
	{
	}

	private void CacheInitialScales()
	{
	}

	private void ResetToInitialScales()
	{
	}

	public void RegisterEvents()
	{
	}

	public void UnregisterEvents()
	{
	}

	private void PlaySkipAdsAnimation(BoostersAnimationData skipAdsAnimationData)
	{
	}

	private void UpdateSkipAdsAnimation(BoostersAnimationData data)
	{
	}

	private void PlayAnimation(Transform skipAdsObject, Vector3 endPoint, float duration, Action callback, Vector3 spreading, ParticleSystem trailParticle, Transform skipAdsImage, float delay = 0f)
	{
	}
}
