using Analytics;
using DB;
using MSKit.UIView;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButterflySpinnerViewRefs : BaseUIViewRefs
{
	public AnalyticsSystem AnalyticsSystem;

	public ButterflySpinnerConfigs Configs;

	public DBInt SkipRespinData;

	public DBInt FreeSpinData;

	public Image BgOverlay;

	public CashObject CashObject;

	public GameObject SpinnersContainer;

	public ItemSpinner[] Spinners;

	public RectTransform[] SpinnersRect;

	public Button StopSpinningButton;

	public Button StopWithoutCoinsSpinningButton;

	public TextMeshProUGUI WatchAdsButtonText;

	public Transform CardsInitialPosition;

	public Image boosterSelectionBgOverlay;

	public GameObject Header;

	public Transform TopBanner;

	public Button CloseButton;

	public Transform PickABooster;

	public Transform PressAndHoldText;

	public Transform Butterfly;

	public Transform ButterflySpot;

	public ParticleSystem ButterTrailParticle;

	public Animator ButterflyAnimator;

	public GameObject WatchAdsStartSpinningContainer;

	public GameObject CoinsStopSpinningContainer;

	public TextMeshProUGUI SpinCoinCostText;

	public GameObject SpinCoinCostContainer;

	public CanvasGroup PanelCanvasGroup;

	public GameObject HandContainer;

	public GameObject HandUp;

	public GameObject HandDown;

	public ButtonPressed RespinButtonState;

	public SkipAdsView SkipAdsView;

	public WatchAdButton SpinOnAdButton;

	public WatchAdButton SpinButton;

	public UserJourneySystem UserJourneySystem;
}
