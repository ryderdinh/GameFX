using System.Collections.Generic;
using MSKit.UIView;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButterflyHudViewRefs : BaseUIViewRefs
{
	public RectTransform Container;

	public ButterflyConfigs ButterflyConfigs;

	public ScoreSystem ScoreSystem;

	public Image ButterflyFillImage;

	public RectTransform ButterflySpawnPosition;

	public RectTransform ButterflyBGRect;

	public List<TrailCollectable> Collectables;

	[Header("Locked State")]
	public GameObject LockedState;

	public TextMeshProUGUI ButterflyLockedText;

	[Header("UnLocked State")]
	public GameObject UnlockedState;

	public TextMeshProUGUI ButterflyUnlockedText;
}
