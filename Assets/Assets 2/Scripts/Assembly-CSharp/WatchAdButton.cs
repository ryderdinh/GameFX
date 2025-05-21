using System;
using Analytics;
using UnityEngine;
using UnityEngine.UI;

public class WatchAdButton : MonoBehaviour, ISkipAdsPurchaseView
{
	[SerializeField]
	private Button _adButton;

	[SerializeField]
	private GameObject _adClipboard;

	[SerializeField]
	private GameObject _skipAdTag;

	[SerializeField]
	private SkipAdsDeductionView _skipAdsDeductionView;

	[SerializeField]
	private SkipAdsObject _skipAdsSystem;

	[SerializeField]
	private Animator _SkipAdsAnimator;

	[SerializeField]
	private UserJourneySystem _userJourneySystem;

	[SerializeField]
	private IAPOfferContext _iAPOfferContext;

	[SerializeField]
	private AnalyticsSystem _analyticsSystem;

	private Action<bool> _callback;

	private Action _actionWhileAnimationDelay;

	private string _placement;

	public void Initialize(Action<bool> callback, string placement)
	{
	}

	public void ActionWhileDelayForAnimation(Action callback)
	{
	}

	public void Show()
	{
	}

	public void UpdateButtonInteractableState(bool state)
	{
	}

	private void RegisterEvents()
	{
	}

	public void WatchAdClicked()
	{
	}

	private void ShowAd()
	{
	}

	private void AdShown(bool result)
	{
	}

	private void UpdateButtonState()
	{
	}

	private void UpdateButtonState(int count)
	{
	}

	protected void PlayButtonImpact()
	{
	}

	private void ShowTearAnimation()
	{
	}

	public void WatchAd()
	{
	}

	public void Close()
	{
	}
}
