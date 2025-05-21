using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardsChestView : MonoBehaviour
{
	[SerializeField]
	private CardsChestSystem _chestSystem;

	[SerializeField]
	private Button _chestButton;

	[SerializeField]
	private Image _progressBar;

	[SerializeField]
	private TextMeshProUGUI _progressText;

	[SerializeField]
	private GameObject _completeParticlesObj;

	[SerializeField]
	private GameObject _blockerObj;

	[SerializeField]
	[Header("Text Bubble")]
	private TextMeshProUGUI _notEnoughMatchesText;

	[SerializeField]
	private RectTransform _bubbleContainer;

	public bool CanShowChestTutorial => false;

	public bool CanShowChest => false;

	public void Initialize()
	{
	}

	private void RegisterEvents()
	{
	}

	public void Show()
	{
	}

	private void ChestButtonClicked()
	{
	}

	private void UpdateProgress()
	{
	}

	private void ResetSpeechBubble()
	{
	}

	private void ShowNotEnoughMatchesPopUp()
	{
	}

	private void PlayButtonImpact()
	{
	}

	private void EnableBlocker()
	{
	}

	private void DisableBlocker()
	{
	}

	private void SetParticlesState(bool state)
	{
	}

	private void SetBlockerState(bool state)
	{
	}
}
