using Analytics;
using MSKit.UIView;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EventIntroViewRefs : BaseUIViewRefs
{
	public Button CloseButton;

	public RectTransform Container;

	public Image Overlay;

	public Transform MissionIcon;

	public Transform BloomPassIcon;

	public Transform BundleOfferIcon;

	public Transform EventHeader;

	public TextMeshProUGUI MissionText;

	public TextMeshProUGUI BloomPassText;

	public TextMeshProUGUI BundleOfferText;

	public Material HeartsPatternMaterial;

	public AnalyticsSystem AnalyticsSystem;
}
