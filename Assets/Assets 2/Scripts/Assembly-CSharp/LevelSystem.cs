using Analytics;
using Core.Server;
using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelSystemObject", menuName = "ScriptableObjects/ProgressionSystem/LevelSystemObject")]
public class LevelSystem : ScriptableObject
{
	[SerializeField]
	private DBInt _dbFTUELevelNo;

	[SerializeField]
	private DBInt _dbLevelNo;

	[SerializeField]
	private DBInt _dbCheckPointNo;

	[SerializeField]
	private DBInt _dbHandholdingLevel;

	[SerializeField]
	private DBInt _dbHighestLevelReached;

	[SerializeField]
	private DBInt _dbLastHighestLevelReached;

	[SerializeField]
	private DBInt _dbHighestLevelReachedForMetaProgress;

	[SerializeField]
	private DBInt _dbHighestLevelReachedInGame;

	[SerializeField]
	private LevelDataConfigs[] LevelDataConfigs;

	[SerializeField]
	private int[] _maxFTUELevels;

	[SerializeField]
	private MatchesSystem _matchSystem;

	[SerializeField]
	private MetaSystem _metaSystem;

	[SerializeField]
	private ScoreSystem _scoreSystem;

	[SerializeField]
	private AnalyticsSystem _analyticsSystem;

	[SerializeField]
	private UserStateBackup _userStateBackup;

	private int _currentLevel;

	private int _FTUELevel;

	private int _stageProgress;

	private int _currentMetaTotalRequiredStars;

	private bool _canGiveStars;

	private CurrentLevelData _currentLevelData;

	private LevelDataConfigs _levelDataConfigs;

	private int _handHoldingLevel;

	private int _ftueLevelId;

	public bool IsCheckPoint => false;

	public int PrePopulationId => 0;

	public bool CanPrePopulateBoard => false;

	public int StageProgress => 0;

	public int CurrentLevel => 0;

	public bool CanGiveStars => false;

	public int CurrentLevelStars => 0;

	public int TotalRequiredStarsForMeta => 0;

	public int CheckPointNumber => 0;

	public int CurrentLevelForView => 0;

	public int HighestLevelReached => 0;

	public int HighestLevelReachedForMetaProgress => 0;

	public int HighestLevelReachedInGame => 0;

	public bool IsMaxLevelReached => false;

	public bool IsLastLevel => false;

	public int GetTotalLevelsByShopIndex(int index)
	{
		return 0;
	}

	public int GetLevelsDataLength()
	{
		return 0;
	}

	public void Initialize()
	{
	}

	public void LoadGame()
	{
	}

	private void SetWorldData()
	{
	}

	public int GetCurrentIncrementalLevel()
	{
		return 0;
	}

	public int GetCurrentIncrementalCheckPoint()
	{
		return 0;
	}

	public void RegisterEvents()
	{
	}

	public void UnregisterEvents()
	{
	}

	public int GetNextCheckPoint(int level)
	{
		return 0;
	}

	public ProgressLevelType GetLevelType(int level)
	{
		return default(ProgressLevelType);
	}

	public bool CanShowNextMilestone(int level)
	{
		return false;
	}

	private void SetCurrentLevelData()
	{
	}

	public int GetNextLevelNumber()
	{
		return 0;
	}

	public int GetButterfliesForNextLevel()
	{
		return 0;
	}

	public int GetNextLevelRequiredScore()
	{
		return 0;
	}

	private int CumulativeRequiredScore()
	{
		return 0;
	}

	public CurrentLevelData GetCurrentLevelData()
	{
		return default(CurrentLevelData);
	}

	public bool IsLevelComplete()
	{
		return false;
	}

	private void UpdateScore(float currentScore)
	{
	}

	public bool WillLevelComplete()
	{
		return false;
	}

	public bool WillStageComplete()
	{
		return false;
	}

	public void ResetLevel()
	{
	}

	private void SetHighestLevelReachedInGame()
	{
	}

	public void LevelComplete()
	{
	}

	public bool IsFTUEActive()
	{
		return false;
	}

	private int GetUpdatedFTUELevelId()
	{
		return 0;
	}

	public int GetFTUELevelId()
	{
		return 0;
	}

	public bool HoldHandForLevel()
	{
		return false;
	}
}
