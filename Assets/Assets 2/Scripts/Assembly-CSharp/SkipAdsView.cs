using System;
using MSKit.ResourcePool;
using MSKit.UIView;
using UnityEngine;

public class SkipAdsView : BaseUIViewController<SkipAdsViewRefs>
{
	[SerializeField]
	private bool _isMainMenuSkipAdsView;

	[SerializeField]
	private IAPOfferContext _iAPOfferContext;

	private int _totalSkipAds;

	private Pool<Transform> _skipAdsPool;

	private Vector3 _initialScale;

	private SkipAdsViewType _skipAdsViewType;

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

	public override void Hide()
	{
	}

	public void UpdateSkipAds(int count)
	{
	}

	private void UpdateSkipAdsText()
	{
	}

	private void OnClick()
	{
	}

	private void PlaySkipAdsAnimation(SkipAdsAnimationData skipAdsAnimationData)
	{
	}

	private void UpdateSkipAdsAnimation(CollectablesData data)
	{
	}

	public virtual void PlayAnimation(Transform skipAdsObject, Vector3 endPoint, float duration, Action callback, float delay = 0f, bool isWorld = false, float coinsSpreadTime = 0.3f, float coinsSpreadDistance = 300f, float delayAfterSpread = 0.1f, float rotation = 360f)
	{
	}

	public void PlayCoinSequence(Transform skipAdsObject, Vector3[] path, float duration, Action callback, float delay = 0f)
	{
	}

	private void UpdateSkipAdsCounter(int count)
	{
	}

	private void ForceUpdateCash(int count)
	{
	}

	public override void InitializeButtons()
	{
	}

	public override void InitializeTexts()
	{
	}
}
