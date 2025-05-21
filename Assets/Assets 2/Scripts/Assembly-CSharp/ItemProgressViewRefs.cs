using DB;
using MSKit.UIView;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemProgressViewRefs : BaseUIViewRefs
{
	public DBBool GiftTutorialShown;

	public ButterflyConfigs ButterflyConfigs;

	public Image ProgressBarFillImage;

	public RectTransform ProgressObjectRect;

	public RectTransform FillBarRect;

	public RectTransform FlowerBGRect;

	public TextMeshProUGUI ProgressText;

	public TextMeshProUGUI ProgressTextBG;

	public RectTransform ProgressTextRect;

	public LevelIconView LevelText;

	public LevelIconView NextLevelText;

	public LevelIconView MilestoneText;

	public GameObject FillerBarContainer;

	public GameObject MilestoneContainer;

	public Transform FillerBarTransform;

	public Image NextItemImage;

	public Bool CanShowProgress;

	public Button AmyButton;

	public ParticleSystem StageClearParticles;

	public Transform TrailsContainer;

	public TrailCollectable[] TrailCollectables;

	[Header("GiftBox")]
	public Image cardsImage;

	public Image cardsImageHighlight;

	public Sprite[] cardsSprites;

	[Header("Butterfly HUD View")]
	public ButterflyHudView ButterflyHudView;
}
