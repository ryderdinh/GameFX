using System;
using UnityEngine;

public class MetaCurrencyAnimator : Coin
{
	[SerializeField]
	private ParticleSystem _particle;

	[SerializeField]
	private GameObject _currencyObject;

	public override void PlayCoinSequence(Vector3[] path, float duration, Action callback, float delay = 0f, bool isWorld = false, float rotation = 360f)
	{
	}

	private void SetCurrencyState(bool state)
	{
	}
}
