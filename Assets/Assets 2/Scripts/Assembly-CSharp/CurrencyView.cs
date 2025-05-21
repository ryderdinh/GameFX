using System;
using DG.Tweening;
using MSKit.UIView;
using UnityEngine;

public class CurrencyView : BaseUIViewController<CurrencyViewRefs>
{
	private float _currentCurrency;

	private Sequence _collectableSequence;

	public override void RegisterEvents()
	{
	}

	public override void UnregisterEvents()
	{
	}

	public override void Initialize()
	{
	}

	public override void Show(object model = null)
	{
	}

	private void ForceUpdateCurrency()
	{
	}

	private void PlayCollectablesAnimation(CollectablesData data)
	{
	}

	private void UpdateScoreWithTrailAnimation(CollectablesData data)
	{
	}

	private void PlayCollectableAnimation(RectTransform collectable, float duration, Vector3[] path, Action action)
	{
	}

	private void UpdateItemProgress(float score)
	{
	}

	public override void InitializeButtons()
	{
	}

	public override void InitializeTexts()
	{
	}
}
