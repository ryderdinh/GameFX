using Analytics;
using MSKit.UIView;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BloomPassPurchaseViewRefs : BaseUIViewRefs
{
	public SeasonalProgressPassSystem SPPSystem;

	public Button PurchaseButton;

	public Button CloseButton;

	public RectTransform Container;

	public Image Overlay;

	public TextMeshProUGUI PriceText;

	public Material BGPatternMaterial;

	public MarketItemData BloomPassOffer;

	public AnalyticsSystem AnalyticsSystem;
}
