using MS.Casual.Market;
using UnityEngine;

[CreateAssetMenu(menuName = "Market/Special/New Item", fileName = null)]
public class SpecialOfferItemData : MarketItemData
{
	public int BrushCutter;

	public int Sprayer;

	public int WheelsBarrow;

	public LiveOpsOfferItemData LiveOpsOfferItemData;

	[Tooltip("In Seconds")]
	public float Time;

	public SpecialOfferType SpecialOfferType;

	public Offers OfferType;

	[SerializeField]
	[Header("Overall Offer Data")]
	private string OfferHeader;

	[SerializeField]
	private ResourcesPrefab<GameObject> OfferAnimatedIcon;

	[SerializeField]
	private ResourcesSprite OfferCardBG;

	[SerializeField]
	private ResourcesSprite OfferCardTimerNotch;

	[SerializeField]
	private ResourcesMaterial OfferHeaderTextMaterial;

	[SerializeField]
	private Color OfferHeaderSubTitleColor;

	[Header("Full Screen Offer Data")]
	[SerializeField]
	private ResourcesSprite OfferHeaderTitle;

	[SerializeField]
	private Color OfferViewBGColor;

	[SerializeField]
	private Color OfferSeparationLineColor;

	[SerializeField]
	private Color OfferHeaderTitleBGColor;

	public ResourcesSprite GetHeaderTitle()
	{
		return null;
	}

	public Color GetHeaderColor()
	{
		return default(Color);
	}

	public Color GetSeparationLineColor()
	{
		return default(Color);
	}

	public ResourcesPrefab<GameObject> GetOfferAnimatedIcon()
	{
		return null;
	}

	public ResourcesSprite GetOfferBG()
	{
		return null;
	}

	public ResourcesSprite GetOfferTimerNotch()
	{
		return null;
	}

	public string GetOfferHeader()
	{
		return null;
	}

	public ResourcesMaterial GetOfferHeaderMaterial()
	{
		return null;
	}

	public Color GetSubHeaderColor()
	{
		return default(Color);
	}

	public Color GetHeaderTitleBGColor()
	{
		return default(Color);
	}
}
