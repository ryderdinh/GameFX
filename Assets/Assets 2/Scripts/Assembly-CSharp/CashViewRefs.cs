using DB;
using MSKit.UIView;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CashViewRefs : BaseUIViewRefs
{
	public RectTransform Container;

	[Header("Cash View")]
	public RectTransform CoinTransform;

	public TextMeshProUGUI CashText;

	public TextMeshProUGUI CashTextBG;

	public Transform CoinContainer;

	public Coin Coin;

	public Int DBCoinsCount;

	public Button CoinButton;

	public ParticleSystem SplashParticles;
}
