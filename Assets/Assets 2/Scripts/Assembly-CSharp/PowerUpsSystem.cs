using System.Collections.Generic;
using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "PowerUpsSystem", menuName = "ScriptableObjects/PowerUps/PowerUpsSystem")]
public class PowerUpsSystem : ScriptableObject
{
	[SerializeField]
	private BasePowerUp[] _powerUps;

	[SerializeField]
	private LevelSystem _levelSystem;

	[SerializeField]
	private TurboModeSystem _turboModeSystem;

	[SerializeField]
	private MetaWorldConfig _metaWorldConfig;

	[SerializeField]
	private UserJourneySystem _userJourneySystem;

	[SerializeField]
	private int _unlockWorld;

	[SerializeField]
	private int _unlockLevel;

	[Header("Tutorial")]
	[SerializeField]
	private DBBool _powerUpTutorialDB;

	[SerializeField]
	private DBBool _powerUpSelectionTutorialDB;

	[SerializeField]
	private int _powerUpTutorialActiveValue;

	private Dictionary<BoostersTypes, BasePowerUp> _powerUpsDict;

	private bool _isTutorialActive;

	private bool _isTutorialCompleted;

	private bool _isSelectionTutorialCompleted;

	public bool IsTutorialCompleted => false;

	public bool IsSelectionTutorialCompleted => false;

	public bool TutorialActive => false;

	public void Initialize()
	{
	}

	public bool IsAnyBoosterEquipped()
	{
		return false;
	}

	public int EquippedPowerUpsCount()
	{
		return 0;
	}

	public void AddPowerUps(BoostersTypes item, int count)
	{
	}

	public bool NewGameStarted()
	{
		return false;
	}

	public void ResetPowerUps()
	{
	}

	public void CompleteTutorial()
	{
	}

	public void CompleteSelectionTutorial()
	{
	}

	public void CheckForTutorial(int slotsLeft)
	{
	}

	public void ActivateTutorial()
	{
	}

	public void DeactivateTutorial()
	{
	}

	public void PowerUpsEquippedComplete()
	{
	}

	public int TotalNumberOfPowerUpsInInventory()
	{
		return 0;
	}

	private void CreatePowerUpsDict()
	{
	}

	public int GetPowerupCount(BoostersTypes boostersType)
	{
		return 0;
	}

	private bool IsUnlocked()
	{
		return false;
	}
}
