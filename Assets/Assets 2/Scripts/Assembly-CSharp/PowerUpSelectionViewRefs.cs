using DB;
using MSKit.UIView;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpSelectionViewRefs : BaseUIViewRefs
{
	public Image Overlay;

	public RectTransform Container;

	public Button PlayButton;

	public GameObject PlayButtonObject;

	public BasePowerUpSelectionView[] PowerUps;

	public PowerUpsSystem PowerUpsSystem;

	[Header("Tutorial Bool")]
	public Bool IsTutorialActive;

	public PowerUpTutorialView PowerUpTutorialView;
}
