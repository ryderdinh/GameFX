using UnityEngine;
using UnityEngine.UI;

public class CardRewardTextView : MonoBehaviour
{
	[SerializeField]
	private GameObject _singleNumberContainer;

	[SerializeField]
	private GameObject _doubleNumberContainer;

	[SerializeField]
	private Image _numberValueImageSingle;

	[SerializeField]
	private Image _numberValueImageDouble;

	[SerializeField]
	private Image _numberValueImageDouble2;

	[SerializeField]
	private AppreciationBannerConfig _configs;

	public void UpdateNumbersSprites(int id)
	{
	}
}
