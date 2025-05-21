using Analytics;
using MSKit.UIView;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MissionCenterViewRefs : BaseUIViewRefs
{
	public TextMeshProUGUI SeasonTimerText;

	public TextMeshProUGUI SeasonTimerText2;

	public TextMeshProUGUI DailyTimerText;

	public Button CloseButton;

	public DailyMissionObjectView DailyMissionObjectView;

	public SeasonalMissionObjectView SeasonalMissionObjectView;

	public MissionSystemController MissionSystemController;

	public Transform DailyMissionObjectViewContainer;

	public Transform SeasonalMissionObjectViewContainer;

	public GameObject SeasonalMissionNextStageBanner;

	public TextMeshProUGUI NextStageText;

	public TextMeshProUGUI NextStageTimerText;

	public CanvasGroup Overlay;

	public Transform ContainerTransform;

	public ScrollRect Scroller;

	public RectTransform Content;

	public RewardAnimationViewController RewardAnimationViewController;

	public AnalyticsSystem AnalyticsSystem;
}
