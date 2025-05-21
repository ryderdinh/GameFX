using MS.Casual.Ads;
using MS.Casual.Market;
using MSKit.UIView;
using UnityEngine;
using UnityEngine.UI;

public class MarketViewRefs : BaseUIViewRefs
{
	public CashView CashView;

	public SkipAdsView SkipAdsView;

	public DailyGiftInAppItemView DailyGiftInAppItemView;

	public RectTransform SkipAdsBestValueTransform;

	public RectTransform CoinsBestValueTransform;

	public RectTransform CardsPack3Transform;

	public Transform ContainerTransform;

	public Transform ContentTransform;

	public Button CloseButton;

	public Button BackButton;

	public RectTransform ScrollRectContent;

	public GameObject RemoveAdsOffer;

	public GameObject StarterPackOffer;

	public GameObject SpecialOfferPack;

	public BaseMarketItemView[] InappItems;

	public ScrollRect Scroller;

	public CanvasGroup Overlay;

	[Header("Offers")]
	public GameObject[] OffersObjects;

	public SpecialOfferInAppItemView[] OffersPacks;

	[Header("Scroller")]
	public VerticalLayoutGroup VerticalLayoutGroup;

	public int ScrollPositionForGameplay;

	public int ScrollPositionForMainMenu;

	[Header("Offers Animations")]
	public PowerUpAnimationView PowerUpsAnimation;

	public MarketCardsAnimationView CardsAnimation;

	[Header("Market Content")]
	public Transform SpecialOffersTransform;

	public Transform CoinsPackTransform;

	public Transform SkipAdsPackTransform;

	public Transform CardsPackTransform;

	public Transform RemoveAdsTransform;

	public Transform RVCoinsTransform;

	public Transform DailyGiftTransform;

	[Header("RemoveAds")]
	public RemoveAdsObject RemoveAdsObject;
}
