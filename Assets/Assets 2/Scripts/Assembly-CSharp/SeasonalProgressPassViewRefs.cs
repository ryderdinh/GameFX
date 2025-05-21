using Analytics;
using MSKit.UIView;
using SocialKit.Views.Utils;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SeasonalProgressPassViewRefs : BaseUIViewRefs
{
	public BloomPassNoAdsPerk BloomPassNoAdsPerk;

	public SeasonalProgressPassSystem SeasonalProgressPassSystem;

	public MatchesProgressMissionSPPView MatchesProgressMissionSPPViewMiddle;

	public MatchesProgressMissionSPPView MatchesProgressMissionSPPViewFirst;

	public RectTransform Container;

	public Transform BottomHudTransform;

	public Transform TopHudTransform;

	public Transform ContentContainerTransform;

	public Button CloseButton;

	public ScrollRect Scroller;

	public GameObject MatchesProgressObject;

	public TextMeshProUGUI MatchesCountText;

	public TextMeshProUGUI MatchesInProgressText;

	public TextMeshProUGUI TimerText;

	public RectTransform Content;

	public CanvasGroup BGCanvas;

	public CanvasGroup BlurCanvas;

	public Material BGPatternMaterial;

	public Button BuyButton;

	public TouchImpact TouchImpact;

	public TextMeshProUGUI ActivateText;

	public Animator BuyButtonAnimator;

	public ParticleSystem Confetti;

	[Header("Pattern")]
	public RectTransform PatternRect;

	[Header("Analtyics")]
	public AnalyticsSystem AnalyticsSystem;
}
