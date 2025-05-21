using Analytics;
using DB;
using MSKit.UIView;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpsSpinnerViewRefs : BaseUIViewRefs
{
	public AnalyticsSystem AnalyticsSystem;

	public BoosterSpinnerConfigs Configs;

	public DBInt SkipRespinData;

	public Image BgOverlay;

	public GameObject SpinnersContainer;

	public ItemSpinner[] Spinners;

	public Transform[] SpinnerAnimationPointsContainers;

	public RectTransform[] SpinnersRect;

	public Image boosterSelectionBgOverlay;

	public GameObject Header;

	public Transform TopBanner;

	public Transform PickABooster;

	public Transform PressAndHoldText;

	public GameObject WatchAdsStartSpinningContainer;

	public Transform cardsInitialPosition;

	public CanvasGroup PanelCanvasGroup;

	public CanvasGroup HeaderCanvasGroup;

	public GameObject HandContainer;

	public GameObject HandUp;

	public GameObject HandDown;

	public ButtonPressed RespinButtonState;

	public SkipAdsView SkipAdsView;

	public AnimatedCardsData[] AnimatedCardsData;

	public WatchAdButton SpinOnAdButton;

	public UserJourneySystem UserJourneySystem;
}
