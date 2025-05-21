using MS.Casual.Market;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LiveOpsOfferInAppItemView : BaseMarketItemView
{
	[SerializeField]
	private TextMeshProUGUI SkipItsText;

	[SerializeField]
	private ContextualOffersObject _offersController;

	[SerializeField]
	private TextMeshProUGUI _remainingTimeText;

	[SerializeField]
	private TextMeshProUGUI _offerHeaderText;

	[SerializeField]
	private RectTransform _offerIconRectTransform;

	[SerializeField]
	private Image _offerCardBg;

	[SerializeField]
	private Image _offerCardTimerNotch;

	public Transform[] AnimationPosition;

	private GameObject _animatedIcon;

	private ISpecialOffer _specialOffer;

	protected override void UpdateData()
	{
	}

	public override void OnItemShown()
	{
	}

	private void LoadSpecialOfferData(ISpecialOffer iSpecialOffer)
	{
	}

	protected override void BuyItem()
	{
	}

	public new Vector3 GetAnimationPosition(int id)
	{
		return default(Vector3);
	}
}
