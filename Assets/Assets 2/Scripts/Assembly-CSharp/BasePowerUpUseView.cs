using UnityEngine;
using UnityEngine.UI;

public abstract class BasePowerUpUseView : MonoBehaviour
{
	[SerializeField]
	private BasePowerUp _powerUp;

	[SerializeField]
	private GameObject _activeGroup;

	[SerializeField]
	private GameObject _inActiveGroup;

	[SerializeField]
	private Button _useButton;

	[SerializeField]
	private ButtonPressed _useButtonState;

	[SerializeField]
	private Transform _container;

	private IPowerUpUseView _powerUpUseView;

	public bool IsEquipped => false;

	public void Initialize(IPowerUpUseView powerUpUseView)
	{
	}

	public bool Show(int index, bool moveHorizontal = true, bool showCTA = false, float ctaDelay = 0f)
	{
		return false;
	}

	public bool Hide(int index, bool moveHorizontal = true)
	{
		return false;
	}

	private void UseClicked()
	{
	}

	private void UpdateState()
	{
	}

	private void PlayButtonImpact()
	{
	}
}
