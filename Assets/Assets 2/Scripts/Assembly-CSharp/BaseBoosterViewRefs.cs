using MSKit.UIView;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BaseBoosterViewRefs : BaseUIViewRefs
{
	public Transform CloseButtonTransform;

	public Button CloseButton;

	public BoosterBubbleView BoosterBubbleView;

	public Image Icon;

	public Image SmallIcon;

	public TextMeshProUGUI Description;

	public Image BoosterName;

	[Header("Booster BG")]
	public ParticleSystem BoosterBGParticle;

	public ParticleSystem IconParticles;
}
