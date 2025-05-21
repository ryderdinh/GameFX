using DB;
using MS.Casual.PieceSort;
using MSKit.UIView;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameplayHudViewRefs : BaseUIViewRefs
{
	public Bool TutorialState;

	public RectTransform Container;

	public MetaWorldConfig MetaWorldConfig;

	[Header("Turbo System")]
	public TurboModeSystem TurboSystem;

	[Header("Pause Button")]
	public Button PauseButton;

	public RectTransform PauseButtonTransform;

	[Header("Cash View")]
	public CashView CashView;

	[Header("Card View")]
	public CardView CardView;

	[Header("Progression View")]
	public ItemProgressView ProgressView;

	public Transform ItemProgressViewTransform;

	[Header("Banner View")]
	public NormalAppreciationBannerView AppreciationBannerView;

	public StageCompleteView StageCompleteBanner;

	public CheckPointReachedBannerView CheckPointBanner;

	public StreakBannerView StreakBannerView;

	public Transform TopHudTransform;

	[Header("Tutorial")]
	public SpeechBubbleView SpeechBubbleViewGameplayTutorial;

	public ButterflyTutorialViewController ButterflyTutorialViewController;

	public BoostersTutorialViewController BoostersTutorialViewController;

	public DropBoosterTutorialView DropBoosterTutorialView;

	public GridConfig GridConfig;

	[Header("Score View")]
	public DBBool CanShowHighScore;

	public ScoreSystem ScoreSystem;

	public TextMeshProUGUI EarningsScoreText;

	public Color HighScoreColorTop;

	public Color DefaultScoreColorTop;

	public ScoreView ScoreView;

	[Header("Coin View")]
	public CoinFloaterView CoinFloaterView;

	[Header("Combo View")]
	public ComboView ComboView;

	[Header("Character View")]
	public CharacterController CharacterController;

	public Transform FemaleContainer;

	public AnimationCurve CustomOutBack;

	public AnimationCurve CustomInBack;

	[Header("Blocker")]
	public GameObject Blocker;

	[Header("Cards Chest")]
	public CardsChestView CardsChest;

	public RectTransform CardsChestTransform;

	public MarketCardsAnimationView CardPackAnimationView;

	public CardsChestTutorialView CardsChestTutorialView;

	public ItemUpgradeSystem ItemUpgradeSystem;

	[Header("Remove Ads")]
	public RemoveAdsButton RemoveAdsButton;

	public RectTransform RemoveAdsButtonRectTransform;

	public BannerRemoveAds BannerRemoveAds;

	public ParticleSystem ConfettiParticles;

	[Header("HUD Images")]
	public Image Hud;

	public Image HudInnerShadow;

	public Image AmyBg;

	public Image CardsBg;

	[Header("Flower Upgrade")]
	public Button FlowerMenu;

	public FlowerUpgradeMenuTutorialController FlowerUpgradeMenuTutorialController;

	[Header("Power Ups")]
	public PowerUpsView PowerUpsView;

	[Header("Turbo Mode")]
	public TurboModeView TurboModeView;

	[Header("Mission Center")]
	public MissionCenterNotificationButtonView MissionCenterButtonView;

	[Header("Live Ops")]
	public LiveOpsSystem LiveOpsSystem;

	public RectTransform MissionCenterButtonRectTransform;
}
