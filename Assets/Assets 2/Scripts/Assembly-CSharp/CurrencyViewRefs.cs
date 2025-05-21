using System.Collections.Generic;
using DB;
using MSKit.UIView;
using TMPro;
using UnityEngine;

public class CurrencyViewRefs : BaseUIViewRefs
{
	public Float Currency;

	public TextMeshProUGUI CurrencyText;

	public TextMeshProUGUI CurrencyTextBG;

	public RectTransform CurrencyTextRect;

	public TextMeshProUGUI CurrencyTextNext;

	public TextMeshProUGUI CurrencyTextBGNext;

	public List<TrailCollectable> Collectables;
}
