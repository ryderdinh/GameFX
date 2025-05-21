using Analytics;
using MSKit.UIView;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ReviveViewRefs : BaseUIViewRefs
{
	public ReviveSystem ReviveSystem;

	public BoostersController BoostersController;

	public SuperWaterCan SuperWaterCan;

	public LevelSystem LevelSystem;

	public GiftSpawnerSystem GiftSpawnerSystem;

	public GameObject RevivePopup;

	public GameObject ReviveAdGroup;

	public RectTransform ReviveBannerTransform;

	public CanvasGroup Animation;

	public Button ReviveBuyButton;

	public Button CloseButton;

	public Transform ReviveAdButtonTransform;

	public ButtonPressed ReviveButtonAnimator;

	public ButtonPressed ReviveOnCoinsButtonAnimator;

	public WatchAdButton ReviveAdButton;

	public Transform ReviveAnimationGroup;

	public UserJourneySystem UserJourneySystem;

	public CanvasGroup CanvasGroup;

	public TextMeshProUGUI RemainingRevivesOnAdCount;

	public TextMeshProUGUI CoinValueOfReviveText;

	public GameObject AdReviveGroup;

	public GameObject CoinReviveGroup;

	public Transform RevivesGroupTransform;

	public GameObject WaterCanParticles;

	[Header("Power ups")]
	public GameObject PowerUpGroup;

	public PowerUpsView PowerUpsView;

	public PowerUpsSystem PowerUpsSystem;

	public Transform PowerUpAnimationGroup;

	[Header("Warning Group")]
	public Transform WarningGroup;

	public CanvasGroup WarningGroupCanvas;

	public TextMeshProUGUI LastCheckPointText;

	public TextMeshProUGUI CurrentLevelText;

	[Header("Gift Warning Group")]
	public Transform GiftWarningGroup;

	public CanvasGroup GiftWarningGroupCanvas;

	[Header("LiveOpsOffer")]
	public LiveOpsSystem LiveOpsSystem;

	public LiveOpsOfferPackView LiveOpsOfferView;

	public ContextualOffersObject ContextualOffersObject;

	[Header("Analytics ")]
	public AnalyticsSystem AnalyticsSystem;
}
