using Analytics;
using MS.Casual.Market;
using MSKit.UIView;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuViewRefs : BaseUIViewRefs
{
	[Header("HighScore View")]
	public HighScoreView HighScoreView;

	[Header("Cash View")]
	public CashView CashView;

	public RectTransform CoinsPositionRect;

	[Header("Meta View")]
	public MetaMenuView MetaView;

	[Header("SkipAds View")]
	public SkipAdsView SkipAdsView;

	[Header("MetaScore Calculator")]
	public MetaScoreCalculcator MetaScoreCalculcator;

	[Header("Main Menu")]
	public Button PlayButton;

	public Button SettingsButton;

	public Button UpgradeButton;

	public ButtonPressed PlayButtonState;

	public Transform ProgressBarTransform;

	public TextMeshProUGUI WorldProgressText;

	public Image ProgressBar;

	[Header("Move Up")]
	public Transform[] ItemsToMoveUp;

	[Header("Move Down")]
	public Transform[] ItemsToMoveDown;

	[Header("Move Right")]
	public Transform[] ItemsToMoveRight;

	[Header("Move Left")]
	public Transform[] ItemsToMoveLeft;

	public CharacterController CharacterController;

	[Header("Progress Bar")]
	public TextMeshProUGUI MetaNameText;

	public TrailCollectable ProgressTrail;

	public Transform TrailsContainer;

	[Header("Card Chest")]
	public CardsChestView CardsChestView;

	[Header("Card Animation")]
	public MarketCardsAnimationView CardsAnimationView;

	[Header("Analytics")]
	public AnalyticsSystem AnalyticsSystem;

	[Header("SpecialOffer Button")]
	public SpecialOfferButtonView SpecialOfferButton;

	[Header("Reward Animation View")]
	public PowerUpAnimationView RewardAnimView;

	[Header("HelpShift")]
	public HelpShiftView HelpShiftView;

	[Header("Flower Upgrade Menu")]
	public Button FlowerUpgradeMenuButton;

	public ItemUpgradeMenuButtonNotification ItemUpgradeMenuButtonNotification;

	[Header("LiveOps System")]
	public LiveOpsSystem LiveOpsSystem;

	public MainMenuLiveOpsView MainMenuLiveOpsView;
}
