using MSKit.UIView;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CurrentScoreViewRefs : BaseUIViewRefs
{
	public RectTransform Container;

	[Header("Current View")]
	public GameObject CurrentScoreView;

	public RectTransform CurrentScoreViewRect;

	public RectTransform CurrentScoreContainer;

	public RectTransform StageTextContainer;

	public RectTransform CurrentScoreTextRect;

	public TextMeshProUGUI CurrentScoreText;

	public TextMeshProUGUI CurrentScoreHeader;

	[Header("HighScore View")]
	public Image HighScoreGlow;

	public ParticleSystem HighScoreParticles;
}
