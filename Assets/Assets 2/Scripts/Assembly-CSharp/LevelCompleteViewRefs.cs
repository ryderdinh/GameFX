using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelCompleteViewRefs : LevelEndViewRefs
{
	public Image Overlay;

	public TextMeshProUGUI LevelCompleteText;

	public Transform BannerTransform;

	public GameObject WorldTextObject;

	public TextMeshProUGUI WorldText;

	public TextMeshProUGUI WorldTextShadow;

	public MetaWorldConfig MetaWorldConfig;

	public LevelSystem LevelSystem;

	public RectTransform CrownRect;

	public RectTransform ShopNameRect;

	public RectTransform CompletedBannerRect;

	public LevelFailFlowers Flower;

	public Transform DividerTransform;

	public ParticleSystem FlowerCompleteParticles;

	[Header("Match Stats")]
	public Transform MatchesCountContainer;

	public TextMeshProUGUI MatchesCount;

	[Header("RV Button")]
	public WatchAdButton RvButton;

	public Transform RvButtonTransform;

	[Header("SPP")]
	public SeasonalProgressPassSystem SeasonalProgressPassSystem;

	[Header("Matches System")]
	public MatchesSystem MatchSystem;
}
