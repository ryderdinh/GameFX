using Analytics;
using MS.Casual.Market;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LiveOpsOfferPackView : BaseMarketItemView
{
	[SerializeField]
	private Offers _offerType;

	[SerializeField]
	private RectTransform _animPositionRect;

	[SerializeField]
	private Image _offerViewBG;

	[SerializeField]
	private Image _freeOfferBGImage;

	[SerializeField]
	private Image _worthOfferBGImage;

	[SerializeField]
	private TextMeshProUGUI _skipAdsFreeText;

	[SerializeField]
	private TextMeshProUGUI _coinsWorthText;

	[SerializeField]
	private TextMeshProUGUI _skipAdsWorthText;

	[SerializeField]
	private TextMeshProUGUI _worthPriceText;

	[SerializeField]
	private AnalyticsSystem _analyticsSystem;

	private ISpecialOffer _specialOffer;

	protected override void Initialize()
	{
	}

	protected override void OnEnable()
	{
	}

	protected override void OnDisable()
	{
	}

	public void OnItemShown(ISpecialOffer model)
	{
	}

	private void UpdateNewOffer()
	{
	}

	private void HideOffer()
	{
	}

	private void OnLiveOpsOfferRewardClaimed(int coinsReward)
	{
	}

	protected virtual void LoadSpecialOfferData(ISpecialOffer iSpecialOffer)
	{
	}

	protected virtual void RegisterEvents()
	{
	}

	protected virtual void UnRegisterEvents()
	{
	}

	protected override void BuyItem()
	{
	}
}
