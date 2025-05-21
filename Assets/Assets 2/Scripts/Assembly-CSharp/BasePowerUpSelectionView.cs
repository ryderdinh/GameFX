using TMPro;
using UnityEngine;
using UnityEngine.UI;

public abstract class BasePowerUpSelectionView : MonoBehaviour
{
	[SerializeField]
	private BasePowerUp _powerUp;

	[SerializeField]
	private Button _selectionButton;

	[SerializeField]
	private ButtonPressed _buttonAnimationState;

	[SerializeField]
	private GameObject _selectionGroup1;

	[SerializeField]
	private GameObject _selectionGroup2;

	[SerializeField]
	private GameObject _inventoryGroup;

	[SerializeField]
	private GameObject _purchaseGroup;

	[SerializeField]
	private TextMeshProUGUI _costText;

	[SerializeField]
	private TextMeshProUGUI _inventoryText;

	private IPowerUpSelectionView _powerUpSelectionView;

	private bool _isSelected;

	public void Initialize(IPowerUpSelectionView powerUpSelectionView)
	{
	}

	public void Show(float animationDelay, bool activateCTA)
	{
	}

	public void Hide()
	{
	}

	private void ActivateCTA(float delay)
	{
	}

	private void SelectClicked()
	{
	}

	private void UpdateState()
	{
	}

	private void ActivateInventoryGroup()
	{
	}

	private void ActivatePurchaseGroup()
	{
	}

	private void ActivateSelectionGroup()
	{
	}

	private void PlayButtonImpact()
	{
	}
}
