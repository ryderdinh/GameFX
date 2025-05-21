using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpsView : MonoBehaviour, IPowerUpUseView
{
	[SerializeField]
	[Header("Power Ups")]
	private PowerUpsSystem _powerUpsSystem;

	[SerializeField]
	private BasePowerUpUseView[] _powerUps;

	[SerializeField]
	private Button _boosterOpenButton;

	[SerializeField]
	private Button[] _boosterCloseButton;

	[SerializeField]
	private GameObject _powerUpsContainer;

	[SerializeField]
	private TextMeshProUGUI _powerUpsCountText;

	[SerializeField]
	private Transform _container;

	[SerializeField]
	private GameObject _powerUpsGroup;

	[SerializeField]
	private Transform _powerUpsLayoutGroup;

	[SerializeField]
	private GameObject _openButtonGroup;

	[SerializeField]
	private GameObject _closeButtonGroup;

	[SerializeField]
	private Image _overlay;

	[SerializeField]
	private ButtonPressed _openButtonState;

	[Header("Animation")]
	[SerializeField]
	private BoostersRewardView[] _boostersRewardView;

	[SerializeField]
	private Transform _startPoint;

	[SerializeField]
	private Transform _endPoint;

	[Header("Refresh Trays")]
	[SerializeField]
	private RefreshTrays _refreshTrays;

	[SerializeField]
	private Transform _refreshTrayTransform;

	[SerializeField]
	private Transform _refreshTrayParent;

	[SerializeField]
	[Header("Tutorial")]
	private bool _canShowTutorial;

	[SerializeField]
	private PowerUpTutorialView _powerUpTutorialView;

	[SerializeField]
	private RefreshTraysTutorial _refreshTraysTutorial;

	[SerializeField]
	private GameObject _blocker;

	[SerializeField]
	private RectTransform _tutorial1MaskPosition;

	[SerializeField]
	private RectTransform _tutorial1HandPosition;

	[SerializeField]
	private RectTransform _tutorial2MaskPosition;

	[SerializeField]
	private RectTransform _tutorial2HandPosition;

	private Vector3 _buttonDefaultPosition;

	private Vector3 _refreshTraysDefaultPosition;

	private int _boostersCount;

	private bool _isAnimatingBoosters;

	private IPowerUpView _powerUpView;

	public void Initialize(IPowerUpView powerUpView)
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public void ForceHideView()
	{
	}

	public void MovePowerUpsIn()
	{
	}

	public void MovePowerUpsOut()
	{
	}

	private void RegisterEvents()
	{
	}

	private void MoveInView()
	{
	}

	private void MoveOutView()
	{
	}

	private void ForceMoveOutView()
	{
	}

	private void OpenPowerUpView()
	{
	}

	private void ClosePowerUpView()
	{
	}

	private void ShowPowerUps()
	{
	}

	private void HidePowerUps()
	{
	}

	private void ForceHidePowerUps()
	{
	}

	private void UpdateViewState()
	{
	}

	private void UpdateNotificationState(int value)
	{
	}

	private void SetPowerUpState(bool state)
	{
	}

	private void PlayButtonImpact()
	{
	}

	private void UpdateBoosterButtonCTA(bool state)
	{
	}

	private void PowerUpsEquipped()
	{
	}

	private void BoosterAnimationCompleted()
	{
	}

	private void ShowTutorial()
	{
	}

	private void HideTutorial()
	{
	}

	private void ShowPowerUpUseTutorial()
	{
	}

	void IPowerUpUseView.UsePowerUp()
	{
	}

	private void SetCloseButtonState(bool state)
	{
	}
}
