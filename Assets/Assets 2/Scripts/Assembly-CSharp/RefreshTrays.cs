using Analytics;
using DB;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RefreshTrays : MonoBehaviour
{
	[SerializeField]
	private DBBool _freeRefreshTraysUsed;

	[SerializeField]
	private DBInt _refreshTraysCostIndex;

	[SerializeField]
	private CashObject _cashObject;

	[SerializeField]
	private TextMeshProUGUI _costText;

	[SerializeField]
	private Button _refreshTraysButton;

	[SerializeField]
	private LevelSystem _levelSystem;

	[SerializeField]
	private ButtonPressed _buttonState;

	[SerializeField]
	private UserJourneySystem _userJourneySystem;

	[SerializeField]
	private Transform _container;

	[SerializeField]
	private GameObject _freeObject;

	[SerializeField]
	private GameObject _coinsObject;

	[SerializeField]
	private AnalyticsSystem _analyticsSystem;

	[SerializeField]
	private PowerUpsSystem _powerUpsSystem;

	private GameConfig _gameConfig;

	private bool _isFreeUsed;

	private bool _isTutorialActive;

	public void Initialize()
	{
	}

	public void Reset()
	{
	}

	public void Show()
	{
	}

	public void MoveIn()
	{
	}

	public void ForceMoveIn()
	{
	}

	public void MoveOut()
	{
	}

	private void UpdateCostText()
	{
	}

	private void RegisterEvents()
	{
	}

	private void SetRefreshTraysButtonAnimator(bool state)
	{
	}

	private void ExecuteRefreshTrays()
	{
	}

	private void IncrementCost()
	{
	}

	protected void PlayButtonImpact()
	{
	}

	private void UpdateCostState()
	{
	}
}
