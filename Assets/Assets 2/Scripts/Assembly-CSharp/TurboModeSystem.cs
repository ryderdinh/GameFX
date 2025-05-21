using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "TurboMode", menuName = "ScriptableObjects/TurboMode")]
public class TurboModeSystem : ScriptableObject
{
	[SerializeField]
	private int _turboModeTotalMoves;

	[SerializeField]
	private int _turboScoreMultiplier;

	[SerializeField]
	private int _turboModeUnlockStage;

	[SerializeField]
	private int _turboModeUnlockWorld;

	[SerializeField]
	[Tooltip("in seconds")]
	private int _cTADelay;

	[Tooltip("in seconds")]
	[SerializeField]
	private int _waitBeforeTutorial;

	[SerializeField]
	private int _movesBeforeTutorial;

	[SerializeField]
	private DBBool _dbCanShowTurboTutorial;

	[SerializeField]
	private DBBool _dbTurboModeUnlocked;

	[Header("Level System")]
	[SerializeField]
	private LevelSystem _levelSystem;

	[Header("World Configs")]
	[SerializeField]
	private MetaWorldConfig _worldConfig;

	[Header("Dish Meshes")]
	[SerializeField]
	private Mesh _turboModeDishMesh;

	[SerializeField]
	private Mesh _turboModeDualDishMesh;

	[SerializeField]
	private PowerUpsSystem _powerUpsSystem;

	[SerializeField]
	private ScoreSystem _scoreSystem;

	private TurboModeState _state;

	private ITurboMode _turboModeView;

	private ITurboMode _turboMode;

	private int _potsPlacedCount;

	private int _potsPlacedForTutorial;

	private bool _canShowTurboModeTutorial;

	private bool _isTutorialActive;

	private float _bonusScore;

	public float BonusScore => 0f;

	public int CTADelay => 0;

	public int WaitBeforeTutorial => 0;

	public int TurboModeTotalMoves => 0;

	public int TurboModeUnlockLevel => 0;

	public Mesh TurboModeDishMesh => null;

	public Mesh TurboModeDualDishMesh => null;

	public int PotsPlacedCount => 0;

	public bool IsTutorialActive => false;

	public bool CanShowTurboModeTutorial => false;

	private bool _isTurboModeUnLocked => false;

	private bool _canUnlock => false;

	public void UpdateTurboView(ITurboMode view)
	{
	}

	public int GetTurboScoreMultiplier()
	{
		return 0;
	}

	public void Initialize(ITurboMode turboMode)
	{
	}

	private void InitializeTurboModeState()
	{
	}

	private void RegisterEvents()
	{
	}

	private void ResetTurboMode()
	{
	}

	private void OnLevelUpEvent(LevelUpData levelUpData)
	{
	}

	private void UnlockTurboModeView()
	{
	}

	public void ActivateTurboMode()
	{
	}

	private void DeactivateTurboMode()
	{
	}

	private void ResetPotsPlacedCount()
	{
	}

	private void UpdateDBCanShowTutorial()
	{
	}

	private void UpdateDBTurboModeUnlocked(bool state)
	{
	}

	public bool PotPlacedForTurboMode()
	{
		return false;
	}

	public TurboModeState GetTurboModeState()
	{
		return default(TurboModeState);
	}

	public bool IsTurboModeActive()
	{
		return false;
	}

	public bool IsTurboModeUnLocked()
	{
		return false;
	}

	private void ShowTutorial()
	{
	}

	public void HideTutorial()
	{
	}
}
