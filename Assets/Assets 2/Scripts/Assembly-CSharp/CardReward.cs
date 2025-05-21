using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardReward : MonoBehaviour
{
	[SerializeField]
	private Transform _cardTransform;

	[SerializeField]
	private MeshRenderer _renderer;

	[SerializeField]
	private GameObject _cardObj;

	[SerializeField]
	private GameObject _progressBarObj;

	[SerializeField]
	private Image _fillBarImage;

	[SerializeField]
	private TextMeshProUGUI _progressText;

	[SerializeField]
	private TextMeshProUGUI _cardRewardText;

	[SerializeField]
	private TextMeshProUGUI _cardRewardTextBg;

	[SerializeField]
	private GameObject _cardRewardTextObject;

	[SerializeField]
	private Sprite _greenSprite;

	[SerializeField]
	private Sprite _yellowSprite;

	private Vector3 _defaultProgressBarScale;

	public Transform ShardTranform => null;

	public void Initialize()
	{
	}

	public void SetTexture(Texture texture)
	{
	}

	public void UpdateCardsProgress(FlowerType flowerType, int cardsGiven, float delay = 0f)
	{
	}

	private void SetProgressBarState(bool state)
	{
	}

	private void SetProgressText(FlowerType flowerType, int cardsGiven)
	{
	}

	public void SetCardsRewardedState(bool state, int count = 0)
	{
	}

	public void SetCardState(bool state)
	{
	}

	private void SetCardsRewardedIconState(bool state)
	{
	}

	private void SetCardsCountText(int count)
	{
	}
}
