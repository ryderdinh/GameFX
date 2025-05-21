using Analytics;
using MSKit.UIView;
using UnityEngine;
using UnityEngine.UI;

public class StarsNotEnoughViewRefs : BaseUIViewRefs
{
	public Image Overlay;

	public RectTransform Container;

	public Button PlayButton;

	public Button[] CloseButtons;

	[Header("Analytics")]
	public AnalyticsSystem AnalyticsSystem;
}
