using DB;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelFailViewRefs : LevelEndViewRefs
{
	public MetaCurrency MetaCurrencySystem;

	public Image Overlay;

	public DBBool FirstInterSkipped;

	public DBBool CanGoToMetaOnFail;

	public LevelSystem LevelSystem;

	public MetaSystem MetaSystem;

	public TextMeshProUGUI RetryButtonText;

	public ScoreSystem ScoreSystem;

	public CurrentScoreView CurrentScoreView;

	public TextMeshProUGUI LevelText;

	public GameObject LevelFailScreen;

	public Transform LevelFailBannerTransform;

	public ReviveView ReviveView;

	public LevelFailFlowers LevelFailFlower;

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
